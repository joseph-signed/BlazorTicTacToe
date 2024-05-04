namespace BlazorTicTacToe.Shared;

public class Player(string connectionId, string name)
{
    public string ConnectionId { get; set; } = connectionId;
    public string Name { get; set; } = name;
}
