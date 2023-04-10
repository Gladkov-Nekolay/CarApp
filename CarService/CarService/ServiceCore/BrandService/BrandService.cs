using AutoMapper;
using CarCore.Entities;
using CarService.Core.Interfaces;
using CarService.Core.ServiceCore.GenericTypeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Core.ServiceCore.BrandService
{
    public class BrandService : GenericTypeService<Brand, IBrandRepository>, IBrandService
    {
        public BrandService(IBrandRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
