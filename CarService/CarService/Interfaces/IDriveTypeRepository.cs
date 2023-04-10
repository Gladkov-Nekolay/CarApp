using CarCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveType = CarCore.Entities.DriveType;

namespace CarService.Core.Interfaces
{
    public interface IDriveTypeRepository : IGenericTypeRepository<DriveType>
    {
    }
}
