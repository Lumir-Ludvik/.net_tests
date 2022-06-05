using Microsoft.AspNetCore.SignalR;

namespace BlazorServer.Hubs;

public class ChatHub : Hub
{
    public Task SendMessages(string user, string message)
    {
        return Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}