using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Core.ServiceCore.GenericTypeService;

namespace CarServices.Core.ServiceCore.BodyTypeService
{
    public class BodyTypeService : GenericTypeService<BodyType, IBodyTypeRepository>, IBodyTypeService
    {
        public BodyTypeService(IBodyTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
