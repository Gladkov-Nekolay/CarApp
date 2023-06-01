using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Infrastructure.Context;

namespace CarServices.Infrastructure.Repository
{
    public class TransmissionTypeEFRepository : GenericTypeEFRepository<TransmissionType>, ITransmissionTypeRepository
    {
        public TransmissionTypeEFRepository(CarAppContext context) : base(context)
        {
        }
    }
}
