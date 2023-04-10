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
            Database.EnsureCreated();
        }
        //public DbSet<BodyType> BodyTypes { get; set; } = null!;
        //public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;
        //public DbSet<DriveType> DriveTypes { get; set; } = null!;
        //public DbSet<EngineType> EngineTypes { get; set; } = null!;
        //public DbSet<ModelOfCar> ModelsOfCars { get; set; } = null!;
        //public DbSet<TransmissionType> TransmissionTypes { get; set; } = null!;
    }
}
