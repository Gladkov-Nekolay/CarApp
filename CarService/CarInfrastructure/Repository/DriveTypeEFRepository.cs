using CarServices.Core.Interfaces;
using CarServices.Infrastructure.Context;
using DriveType = CarCore.Entities.DriveType;

namespace CarServices.Infrastructure.Repository
{
    public class DriveTypeEFRepository : GenericTypeEFRepository<DriveType>, IDriveTypeRepository
    {
        public DriveTypeEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
