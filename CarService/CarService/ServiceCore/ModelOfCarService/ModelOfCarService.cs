using AutoMapper;
using CarCore.Entities;
using CarService.Core.Interfaces;
using CarService.Core.ServiceCore.GenericTypeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Core.ServiceCore.ModelOfCarService
{
    public class ModelOfCarService : GenericTypeService<ModelOfCar, IModelOfCarRepository>, IModelOfCarService
    {
        public ModelOfCarService(IModelOfCarRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
