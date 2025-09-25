using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;

namespace Demo.Web.Ghas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize] // Require JWT authentication
    public class FileController : Controller
    {
        [HttpPost]
        public IActionResult Upload(FileViewModel fileViewModel)
        {
            if (fileViewModel == null || string.IsNullOrEmpty(fileViewModel.DataBase64)) 
                return BadRequest("Invalid file data provided.");

            var fileData = Convert.FromBase64String(fileViewModel.DataBase64);
            if (fileData.Length <= 0) 
                return BadRequest("Empty file data.");

            // Ensure directory exists
            var uploadsDir = Path.Join(Directory.GetCurrentDirectory(), @"wwwroot/images/products");
            if (!Directory.Exists(uploadsDir))
            {
                Directory.CreateDirectory(uploadsDir);
            }

            var fullPath = Path.Join(uploadsDir, fileViewModel.FileName);
            
            // Check if file exists and remove it
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            
            System.IO.File.WriteAllBytes(fullPath, fileData);

            return Ok(new { message = "File uploaded successfully", fileName = fileViewModel.FileName });
        }
    }

    public class FileViewModel
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public string DataBase64 { get; set; }
    }
}
