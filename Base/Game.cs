using NGame.Core;
using NGame.Model;

namespace NGame.Base;

public abstract class Game<TGameOptions, TPlayer> : GameState<TGameOptions, TPlayer>, IGameBehavior<TGameOptions, TPlayer>
    where TGameOptions : IGameOptions, new()
    where TPlayer : IPlayer
{

    protected TGameOptions Options { get; private set; }

    public Game() : base() { }

    public bool IsAcceptingPlayers => base.Players.Count() < Options.MaxPlayers;
    
    public async Task AddPlayerAsync(TPlayer player)
    {
        throw new NotImplementedException();
    }

    public async Task InitAsync()
    {
        await Task.Run(DoInit);
    }

    protected abstract void DoInit();

    public async Task StartAsync()
    {
        await Task.Run(DoStart);

        base.State = State.Running;
    }

    /// <summary>
    /// Should implement basic starting procedure.
    /// E.g. Determining starting player etc.
    /// </summary>
    protected abstract void DoStart();

}
