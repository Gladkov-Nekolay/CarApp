using AnnouncementCore.Services;
using AnnouncementCore.Entities;
using AnnouncementCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnnouncementMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _service;
        public AnnouncementController(IAnnouncementService service)
        {
            _service = service;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult> AddAnnouncementAsync(AnnouncementCreationModel announcementModel)
        {
            await _service.AddAnnouncementAsync(announcementModel);
            return new OkResult();

        }
        [Route("[action]")]
        [HttpPut]
        public async Task<ActionResult> UpdateAnnouncementAsync(Announcement announcement)
        {
            await _service.UpdateAnnouncementAsync(announcement);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetAllAsync([FromQuery] PaginationSettingModel paginationSettiongsModel)
        {
            return new OkObjectResult(await _service.GetAllAsync(paginationSettiongsModel));
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetForAccountAnnouncementAsync([FromQuery] PaginationSettingModel paginationSettiongsModel, long ID)
        {
            return new OkObjectResult(await _service.GetForAccountAnnouncementAsync(paginationSettiongsModel, ID));
        }
        [Route("[action]")]
        [HttpDelete]
        public async Task<ActionResult> DeleteAnnouncementAsync(long ID)
        {
            await _service.DeleteAnnouncementAsync(ID);
            return new OkResult();
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult> GetByIDAnnouncementAsync(long ID)
        {
            return new OkObjectResult(await _service.GetByIDAnnouncementAsync(ID));
        }
    }
}
