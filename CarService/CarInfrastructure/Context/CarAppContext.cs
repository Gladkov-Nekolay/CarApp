using CarCore.Entities;
using Microsoft.EntityFrameworkCore;
using DriveType = CarCore.Entities.DriveType;

namespace CarServices.Infrastructure.Context
{
    public class CarAppContext : DbContext
    {
        public CarAppContext(DbContextOptions<CarAppContext> options) : base(options)
        {
            Database.EnsureCreated();
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
