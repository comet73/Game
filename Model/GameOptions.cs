using NGame.Core;

namespace NGame.Model;

public class GameOptions : IGameOptions {
    public int MinPlayers { get; set; } = 2;

    public int MaxPlayers { get; set; } = 2;

    public GameOptions() : base() {}
}