using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRBase.Hubs;
using SignalRBase.Models;

namespace SignalRBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationsController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public IActionResult Post(NotificationDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _hubContext.Clients.All.SendAsync("SendNotification", model);

            return Ok(model);
        }

    }
}
