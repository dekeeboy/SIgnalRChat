using Microsoft.AspNetCore.SignalR;
using SIgnalRChat.Hubs;

namespace SIgnalRChat.Services
{
    public class StockService
    {
        private readonly IHubContext<DashBoardHub> _hubContext;

        public StockService(IHubContext<DashBoardHub> hubContext)
        {
            _hubContext = hubContext;
        }

        // Simulate receiving the stock price updates and broadcast them
        public async Task UpdateStockPrice(string stockSymbol, double newPrice)
        {
            string message = $"The new price for {stockSymbol} is {newPrice} USD.";

            // send the message to all the connected clients
            await _hubContext.Clients.All.SendAsync(message);
        }
    }
}
