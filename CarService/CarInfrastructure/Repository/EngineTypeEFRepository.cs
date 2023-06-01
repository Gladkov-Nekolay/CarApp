using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Infrastructure.Context;

namespace CarServices.Infrastructure.Repository
{
    public class EngineTypeEFRepository : GenericTypeEFRepository<EngineType>, IEngineTypeRepository
    {
        public EngineTypeEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
