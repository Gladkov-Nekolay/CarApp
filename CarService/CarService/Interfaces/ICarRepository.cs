using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.Interfaces
{
    public interface ICarRepository
    {
        public Task AddCarAsync(Car car);
        public Task UpdateCarAsync(Car car);
        public Task DeleteCarAsync(long ID);
        public Task<Car> GetCarAsync(long ID);
        public Task<Car> GetAsNoTrackingAsync(long id);
        public Task<List<Car>> GetAllAsync(PagenationSettingsModel pagenationSettings);
        public Task<List<Car>> GetAllAsNotTrackingAsync(PagenationSettingsModel pagenationSettings);
    }
}
