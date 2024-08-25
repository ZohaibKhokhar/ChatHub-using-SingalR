using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CHatHub.Hubs
{
 
    public class ChatHub:Hub
    {
        // Method to send a message to all connected clients
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

}
