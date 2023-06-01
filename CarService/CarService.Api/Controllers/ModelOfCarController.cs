using AutoMapper;
using CarCore.Entities;
using CarServices.Core.Models;
using CarServices.Core.ServiceCore.ModelOfCarService;
using Microsoft.AspNetCore.Mvc;

namespace CarServices.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelOfCarController : ControllerBase
    {
        private readonly IModelOfCarService Service;
        private readonly IMapper Mapper;
        public ModelOfCarController(IModelOfCarService ModelService, IMapper mapper)
        {
            Service = ModelService;
            Mapper = mapper;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> AddAsync(ModelOfCarCreationModel entityModel)
        {
            var entity = Mapper.Map<ModelOfCarCreationModel, ModelOfCar>(entityModel);
            await Service.AddAsync(entity);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpDelete]
        public async Task<ActionResult> DeleteAsync(long ID)
        {
            await Service.DeleteAsync(ID);
            return new OkResult();
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult> UpdateAsync(ModelOfCar entity)
        {
            await Service.UpdateAsync(entity);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAsync(long id)
        {
            return new OkObjectResult(await Service.GetAsync(id));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAsNoTrackingAsync(long id)
        {
            return new OkObjectResult(await Service.GetAsNoTrackingAsync(id));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAllAsNotTrackingAsync([FromQuery] PagenationSettingsModel paginationSettings)
        {
            return new OkObjectResult(await Service.GetAllAsNotTrackingAsync(paginationSettings));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAllAsync([FromQuery] PagenationSettingsModel paginationSettings)
        {
            return new OkObjectResult(await Service.GetAllAsync(paginationSettings));
        }
    }
}
