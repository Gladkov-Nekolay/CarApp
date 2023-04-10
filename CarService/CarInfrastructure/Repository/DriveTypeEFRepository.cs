using CarService.Core.Interfaces;
using CarService.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveType = CarCore.Entities.DriveType;

namespace CarService.Infrastructure.Repository
{
    public class DriveTypeEFRepository : GenericTypeEFRepository<DriveType>, IDriveTypeRepository
    {
        public DriveTypeEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
