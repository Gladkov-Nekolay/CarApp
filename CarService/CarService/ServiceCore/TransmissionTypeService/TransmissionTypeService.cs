using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Interfaces;
using CarServices.Core.ServiceCore.GenericTypeService;

namespace CarServices.Core.ServiceCore.TransmissionTypeService
{
    public class TransmissionTypeService : GenericTypeService<TransmissionType, ITransmissionTypeRepository>, ITransmissionTypeService
    {
        public TransmissionTypeService(ITransmissionTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
