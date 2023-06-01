using CarService.Core.Interfaces;
using CarService.Core.Profiles;
using CarService.Core.ServiceCore.BodyTypeService;
using CarService.Core.ServiceCore.BrandService;
using CarService.Core.ServiceCore.CarService;
using CarService.Core.ServiceCore.DriveTypeService;
using CarService.Core.ServiceCore.EngineTypeService;
using CarService.Core.ServiceCore.ModelOfCarService;
using CarService.Core.ServiceCore.TransmissionTypeService;
using CarService.Infrastructure.Context;
using CarService.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
// Add services to the container.

services.AddDbContext<CarAppContext>(context => context.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//domain
services.AddScoped<ICarService, ÑarService>();
services.AddScoped<IBodyTypeService, BodyTypeService>();
services.AddScoped<IBrandService, BrandService>();
services.AddScoped<IDriveTypeService, DriveTypeService>();
services.AddScoped<IEngineTypeService, EngineTypeService>();
services.AddScoped<IModelOfCarService, ModelOfCarService>();
services.AddScoped<ITransmissionTypeService, TransmissionTypeService>();

//infrastructure
services.AddScoped<ICarRepository, CarEFRepository>();
services.AddScoped<IBodyTypeRepository, BodyTypeEFRepository>();
services.AddScoped<IBrandRepository, BrandEFRepository>();
services.AddScoped<IDriveTypeRepository, DriveTypeEFRepository>();
services.AddScoped<IEngineTypeRepository, EngineTypeEFRepository>();
services.AddScoped<IModelOfCarRepository, ModelOfCarEFRepository>();
services.AddScoped<ITransmissionTypeRepository, TransmissionTypeEFRepository>();

//automapping
services.AddAutoMapper(
               typeof(CarProfile),
               typeof(BodyTypeProfile),
               typeof(BrandProfile),
               typeof(DriveTypeProfile),
               typeof(EngineTypeProfile),
               typeof(ModelOfCarProfile),
               typeof(TransmissionTypeProfile)
               );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
