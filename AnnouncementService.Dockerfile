#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

#core 
COPY /AnnouncementService/AnnouncementCore ./AnnouncementService/AnnouncementCore
RUN dotnet publish AnnouncementService/AnnouncementCore/AnnouncementCore.csproj -o out

#infrastructure
COPY /AnnouncementService/AnnouncementInfrastructure ./AnnouncementService/AnnouncementInfrastructure
RUN dotnet publish AnnouncementService/AnnouncementInfrastructure/AnnouncementInfrastructure.csproj -o out

#web 
COPY /AnnouncementService/AnnouncementService ./AnnouncementService/AnnouncementService
RUN dotnet publish AnnouncementService/AnnouncementService/AnnouncementMicroservice.csproj -o out

#final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "AnnouncementMicroservice.dll"]