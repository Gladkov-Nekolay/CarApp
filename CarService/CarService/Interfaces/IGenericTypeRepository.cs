using CarCore.Entities;
using CarServices.Core.Models;

namespace CarServices.Core.Interfaces
{
    public interface IGenericTypeRepository<T> where T : GenericType
    {
        public Task AddAsync(T entity);
        public Task DeleteAsync(long ID);
        public Task UpdateAsync(T entity);
        public Task<T?> GetAsync(long id);
        public Task<T?> GetAsNoTrackingAsync(long id);
        public Task<List<T>> GetAllAsNotTrackingAsync(PagenationSettingsModel pagenationSettings);
        public Task<List<T>> GetAllAsync(PagenationSettingsModel pagenationSettings);
    }
}
