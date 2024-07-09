using Microsoft.AspNetCore.Mvc;
using SqlLite.API.Services;

namespace SqlLite.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class NotificationsController(INotificationService notification) : ControllerBase
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var notifications = await notification.GetAllAsync(cancellationToken);

            if (notification is null)
            {
                return NotFound(notifications);
            }

            return Ok(notifications);
        }

        /*[HttpGet("Id")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var notification = await notification.GetByIdAsync(id, cancellationToken);  

        }*/
    }
}
