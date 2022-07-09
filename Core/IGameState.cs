namespace Game.Core {
    public interface IGameState : IIdentifiable {
        bool IsRunning { get; }
    }
}