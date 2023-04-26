using CarCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveType = CarCore.Entities.DriveType;

namespace CarService.Infrastructure.Context
{
    public class CarAppContext : DbContext
    {
        public CarAppContext(DbContextOptions<CarAppContext> options) : base(options)
        {
        }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Brand> Brands { get; set; } 
        public DbSet<DriveType> DriveTypes { get; set; } 
        public DbSet<EngineType> EngineTypes { get; set; } 
        public DbSet<ModelOfCar> ModelsOfCars { get; set; } 
        public DbSet<TransmissionType> TransmissionTypes { get; set; } 
        public DbSet<Car> Cars { get; set; } 
    }
}
