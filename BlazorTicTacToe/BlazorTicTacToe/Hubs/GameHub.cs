using Microsoft.AspNetCore.SignalR;

namespace BlazorTicTacToe.Hubs;

public class GameHub : Hub
{
    public override Task OnConnectedAsync()
    {
        Console.WriteLine($"Play with ID '{Context.ConnectionId}' connected.");

        return base.OnConnectedAsync();
    }
}
