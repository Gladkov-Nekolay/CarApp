using CarServices.Core.Interfaces;
using CarServices.Core.Profiles;
using CarServices.Core.ServiceCore.BodyTypeService;
using CarServices.Core.ServiceCore.BrandService;
using CarServices.Core.ServiceCore.CarServices;
using CarServices.Core.ServiceCore.DriveTypeService;
using CarServices.Core.ServiceCore.EngineTypeService;
using CarServices.Core.ServiceCore.ModelOfCarService;
using CarServices.Core.ServiceCore.TransmissionTypeService;
using CarServices.Infrastructure.Context;
using CarServices.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
// Add services to the container.

services.AddDbContext<CarAppContext>(context => context.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//domain
services.AddScoped<IBodyTypeService, BodyTypeService>();
services.AddScoped<IBrandService, BrandService>();
services.AddScoped<IDriveTypeService, DriveTypeService>();
services.AddScoped<IEngineTypeService, EngineTypeService>();
services.AddScoped<IModelOfCarService, ModelOfCarService>();
services.AddScoped<ITransmissionTypeService, TransmissionTypeService>();
services.AddScoped<ICarService, CarService>();

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
