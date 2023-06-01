using CarCore.Entities;
using CarServices.Core.Models;
using CarServices.Core.ServiceCore.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace CarServices.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;

        public CarController(ICarService service)
        {
            carService = service;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> AddCarAsync(CarCreationModel CarModel)
        {
            await carService.AddCarAsync(CarModel);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpPut]
        public async Task<ActionResult> UpdateCarAsync(Car car)
        {
            await carService.UpdateCarAsync(car);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpDelete]
        public async Task<ActionResult> DeleteCarAsync(long ID)
        {
            await carService.DeleteCarAsync(ID);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetCarAsync(long ID)
        {
            return new OkObjectResult(await carService.GetCarAsync(ID));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAsNoTrackingAsync(long id)
        {
            return new OkObjectResult(await carService.GetAsNoTrackingAsync(id));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAllAsync([FromQuery] PagenationSettingsModel paginationSettings)
        {
            return new OkObjectResult(await carService.GetAllAsync(paginationSettings));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAllAsNotTrackingAsync([FromQuery] PagenationSettingsModel paginationSettings)
        {
            return new OkObjectResult(await carService.GetAllAsNotTrackingAsync(paginationSettings));
        }
    }
}
