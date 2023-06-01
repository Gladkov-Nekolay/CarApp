using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Core.ServiceCore.GenericTypeService;

namespace CarServices.Core.ServiceCore.ModelOfCarService
{
    public class ModelOfCarService : GenericTypeService<ModelOfCar, IModelOfCarRepository>, IModelOfCarService
    {
        public ModelOfCarService(IModelOfCarRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
