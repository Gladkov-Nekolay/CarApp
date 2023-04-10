using CarCore.Entities;
using CarService.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Core.ServiceCore.CarService
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
