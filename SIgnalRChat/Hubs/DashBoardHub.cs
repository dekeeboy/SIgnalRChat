using Microsoft.AspNetCore.SignalR;

namespace SIgnalRChat.Hubs
{
    public class DashBoardHub : Hub
    {
        public async Task SendDataUpdate(string data)
        {
            await Clients.All.SendAsync("ReceiveMessage", data);
        }
    }
}
