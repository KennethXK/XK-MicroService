
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app

COPY . /app

EXPOSE 80/tcp

ENTRYPOINT ["dotnet", "Business.Host.dll"]