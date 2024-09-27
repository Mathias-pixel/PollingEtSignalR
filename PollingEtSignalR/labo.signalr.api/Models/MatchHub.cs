using labo.signalr.api.Data;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;

namespace labo.signalr.api.Models
{
    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();
    }
    public class MatchHub : Hub
    {

        ApplicationDbContext _context;

        public MatchHub(ApplicationDbContext context)
        {
            _context = context;
        }
        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            UserHandler.ConnectedIds.Add(Context.ConnectionId); 
        }

    }
}
