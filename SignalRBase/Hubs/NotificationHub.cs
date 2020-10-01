using Microsoft.AspNetCore.SignalR;
using SignalRBase.Models;
using System.Threading.Tasks;

namespace SignalRBase.Hubs
{
    public class NotificationHub : Hub
    {
        public Task GetNotification(NotificationDto model)
        {

            Clients.AllExcept(Context.ConnectionId).SendAsync("SendNotification", model);
            return Task.CompletedTask;
        }
    }
}
