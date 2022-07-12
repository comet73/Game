namespace NGame.Core {

    /// <summary>
    /// Very basic interface for games.
    /// </summary>
    interface IGame<TGameOptions, TPlayer> : IGameState<TGameOptions, TPlayer>, IGameBehavior<TGameOptions, TPlayer> 
        where TGameOptions : IGameOptions, new()
        where TPlayer : IPlayer
    {
        

    }
}