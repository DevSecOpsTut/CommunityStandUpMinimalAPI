 # syntax=docker/dockerfile:1
  FROM mcr.microsoft.com/dotnet/aspnet:6.0
  COPY . App/ 
  WORKDIR /App

  EXPOSE 443
  EXPOSE 80

  ENTRYPOINT ["dotnet", "TodoApi.dll"]