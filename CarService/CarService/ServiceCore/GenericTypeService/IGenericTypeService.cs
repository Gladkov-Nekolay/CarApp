using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.ServiceCore.GenericTypeService
{
    public interface IGenericTypeService<T> where T : GenericType
    {
        public Task AddAsync(T entity);
        public Task DeleteAsync(long ID);
        public Task UpdateAsync(T entity);
        public Task<T?> GetAsync(long id);
        public Task<T?> GetAsNoTrackingAsync(long id);
        public Task<List<T>> GetAllAsNotTrackingAsync(PagenationSettingsModel paginationSettings);
        public Task<List<T>> GetAllAsync(PagenationSettingsModel paginationSettings);
    }
}
