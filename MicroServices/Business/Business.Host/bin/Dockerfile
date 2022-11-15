#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

COPY . /app

EXPOSE 80/tcp

ENTRYPOINT ["dotnet", "Business.Host.dll"]