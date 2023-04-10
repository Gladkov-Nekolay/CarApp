using CarCore.Entities;
using CarService.Core.Interfaces;
using CarService.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Infrastructure.Repository
{
    public class BodyTypeEFRepository : GenericTypeEFRepository<BodyType>,IBodyTypeRepository
    {
        public BodyTypeEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
