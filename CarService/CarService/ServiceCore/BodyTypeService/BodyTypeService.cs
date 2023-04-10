using AutoMapper;
using CarCore.Entities;
using CarService.Core.Interfaces;
using CarService.Core.ServiceCore.GenericTypeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Core.ServiceCore.BodyTypeService
{
    public class BodyTypeService : GenericTypeService<BodyType, IBodyTypeRepository>, IBodyTypeService
    {
        public BodyTypeService(IBodyTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
