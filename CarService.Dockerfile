#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

#core 
COPY /CarService/CarService ./CarService/CarService
RUN dotnet publish CarService/CarService/CarServices.Core.csproj -o out

#infrastructure
COPY /CarService/CarInfrastructure ./CarService/CarInfrastructure
RUN dotnet publish CarService/CarInfrastructure/CarServices.Infrastructure.csproj -o out

#web 
COPY /CarService/CarService.Api ./CarService/CarService.Api
RUN dotnet publish CarService/CarService.Api/CarServices.Api.csproj -o out

#final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "CarServices.Api.dll"]


#FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
#WORKDIR /src
#COPY ["CarService.Api/CarService.Api.csproj", "CarService.Api/"]
#RUN dotnet restore "CarService.Api/CarService.Api.csproj"
#COPY . .
#WORKDIR "/src/CarService.Api"
#RUN dotnet build "CarService.Api.csproj" -c Release -o /app/build

#FROM build AS publish
#RUN dotnet publish "CarService.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "CarService.Api.dll"]