using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Infrastructure.Context;

namespace CarServices.Infrastructure.Repository
{
    public class ModelOfCarEFRepository : GenericTypeEFRepository<ModelOfCar>, IModelOfCarRepository
    {
        public ModelOfCarEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
