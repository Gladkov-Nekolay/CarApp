using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Core.ServiceCore.GenericTypeService;

namespace CarServices.Core.ServiceCore.EngineTypeService
{
    public class EngineTypeService : GenericTypeService<EngineType, IEngineTypeRepository>, IEngineTypeService
    {
        public EngineTypeService(IEngineTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
