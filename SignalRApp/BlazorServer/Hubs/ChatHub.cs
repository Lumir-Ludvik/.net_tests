using Microsoft.AspNetCore.SignalR;

namespace BlazorServer.Hubs;

public class ChatHub : Hub
{
    public Task SendMessages(string user, string message)
    {
        return Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public Task SendStatus(string user, bool status)
    {
        return Clients.All.SendAsync("IsOnline", user, status);
    }

    public Task JoinGroup(string roomName)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, roomName);
    }

    public Task LeaveGroup(string roomName)
    {
        return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
    }

    public Task SendToGroup(string user, string message, string roomName)
    {
        return Clients.Group(roomName).SendAsync("GroupMessage", user, message);
    }
}