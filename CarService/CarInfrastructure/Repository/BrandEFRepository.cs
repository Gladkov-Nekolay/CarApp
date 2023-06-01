using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Infrastructure.Context;

namespace CarServices.Infrastructure.Repository
{
    public class BrandEFRepository : GenericTypeEFRepository<Brand>, IBrandRepository
    {
        public BrandEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
