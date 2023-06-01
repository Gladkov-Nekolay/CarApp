using AnnouncementCore.Interfaces;
using AnnouncementCore.Profiles;
using AnnouncementCore.Services;
using AnnouncementInfrastructure.Context;
using AnnouncementInfrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddDbContext<AnnouncementContext>(context => context.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));

// Add services to the container.

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

//domain
services.AddScoped<IAnnouncementService, AnnouncementService>();
//infrastructure
services.AddScoped<IAnnouncementRepository, AnnouncementEFRepository>();
//automapping
services.AddAutoMapper(
    typeof(AnnouncementProfile)
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
