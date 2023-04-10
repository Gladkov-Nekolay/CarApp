using CarService.Core.ServiceCore.GenericTypeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveType = CarCore.Entities.DriveType;

namespace CarService.Core.ServiceCore.DriveTypeService
{
    public interface IDriveTypeService : IGenericTypeService<DriveType>
    {
    }
}
