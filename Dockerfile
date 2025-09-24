FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build 
# 9.0-alpine
WORKDIR /app

COPY MyApp.API .

RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENTRYPOINT ["dotnet", "MyApp.API.dll"]
