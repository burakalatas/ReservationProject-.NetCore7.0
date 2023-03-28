using Microsoft.AspNetCore.SignalR;
using SignalRChartApi.Models;

namespace SignalRChartApi.Hubs
{
    public class VisitorHub : Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("ReceiveVisitors", _visitorService.GetVisitorChart());
        }
    }
}
