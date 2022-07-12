namespace NGame.Core {

    /// <summary>
    /// Behaviour for IGame objects
    /// </summary>
    public interface IGameBehavior<TGameOptions, TPlayer> 
        where TGameOptions : IGameOptions, new()
        where TPlayer : IPlayer
    {

        /// <summary>
        /// true, if the game accepts further players.
        /// </summary>
        bool IsAcceptingPlayers { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player">The Player to be added</param>
        /// <returns></returns>
        Task AddPlayerAsync(TPlayer player);

        /// <summary>
        /// Must be called before an IGame can be started
        /// </summary>
        /// <returns>Task must be awaited before calling Start()</returns>
        Task InitAsync();

        /// <summary>
        /// Starts the game
        /// </summary>
        /// <returns>Task object</returns>
        Task StartAsync();

        
    }
}
