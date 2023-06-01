using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.ServiceCore.CarServices
{
    public interface ICarService
    {
        public Task AddCarAsync(CarCreationModel model);
        public Task UpdateCarAsync(Car car);
        public Task DeleteCarAsync(long ID);
        public Task<Car> GetCarAsync(long ID);
        public Task<Car> GetAsNoTrackingAsync(long id);
        public Task<List<Car>> GetAllAsync(PagenationSettingsModel paginationSettings);
        public Task<List<Car>> GetAllAsNotTrackingAsync(PagenationSettingsModel paginationSettings);
    }
}
