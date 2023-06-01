using AutoMapper;
using CarServices.Core.Interfaces;
using CarServices.Core.ServiceCore.GenericTypeService;
using DriveType = CarCore.Entities.DriveType;

namespace CarServices.Core.ServiceCore.DriveTypeService
{
    public class DriveTypeService : GenericTypeService<DriveType, IDriveTypeRepository>, IDriveTypeService
    {
        public DriveTypeService(IDriveTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
