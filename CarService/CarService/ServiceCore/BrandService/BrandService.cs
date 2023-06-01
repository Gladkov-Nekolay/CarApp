using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Core.ServiceCore.GenericTypeService;

namespace CarServices.Core.ServiceCore.BrandService
{
    public class BrandService : GenericTypeService<Brand, IBrandRepository>, IBrandService
    {
        public BrandService(IBrandRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
