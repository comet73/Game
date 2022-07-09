namespace Game.Core {

    /// <summary>
    /// Behaviour for IGame objects
    /// </summary>
    public interface IGameBehavior {

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
