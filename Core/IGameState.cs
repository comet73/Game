namespace NGame.Core {

    /// <summary>
    /// A Game walks through 4 different states:
    /// - Constructed but not initialized (!IsReady && !IsRunning && !IsTerminated)
    /// - Initialized after a call to InitAsync() (IsReady && !IsRunning && !IsTerminated)
    /// - Started after a call to StartAsync() (!IsReady && IsRunning && !IsTerminated)
    /// - Terminated (!IsReady && !IsRunning && IsTerminated)
    /// </summary>
    public interface IGameState<TGameOptions, TPlayer> 
        where TGameOptions : IGameOptions, new()
        where TPlayer : IPlayer 
    {

        IEnumerable<TPlayer> Players { get; }

        /// <summary>
        /// Indicates wether the game is completely initialized and ready to be started.
        /// </summary>
        bool IsReady { get; }

        /// <summary>
        /// Indicates wether the game is running vs. terminated and ready.
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// Indicates wether the game has ended.
        /// </summary>
        bool IsTerminated { get; }
    }
}