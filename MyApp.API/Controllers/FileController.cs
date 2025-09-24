using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Microsoft.AspNetCore.Http;

namespace Demo.Web.Ghas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [IgnoreAntiforgeryToken]
    public class FileController : Controller
    {
        private const string AUTH_KEY = "x-demo-auth";
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Upload(FileViewModel fileViewModel)
        {
            if (!Request.Headers.ContainsKey("auth-key") || Request.Headers["auth-key"].ToString() != AUTH_KEY)
            {
                return Unauthorized();
            }

            if (fileViewModel == null || string.IsNullOrEmpty(fileViewModel.DataBase64)) return BadRequest();

            var fileData = Convert.FromBase64String(fileViewModel.DataBase64);
            if (fileData.Length <= 0) return BadRequest();

            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images/products", fileViewModel.FileName);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            System.IO.File.WriteAllBytes(fullPath, fileData);

            return Ok();
        }

    }

    public class FileViewModel
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public string DataBase64 { get; set; }
    }
}
