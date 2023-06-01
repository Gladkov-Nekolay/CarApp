using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Infrastructure.Context;

namespace CarServices.Infrastructure.Repository
{
    public class BodyTypeEFRepository : GenericTypeEFRepository<BodyType>, IBodyTypeRepository
    {
        public BodyTypeEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
