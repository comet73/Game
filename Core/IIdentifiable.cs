namespace Game.Core {

    /// <summary>
    /// Exposes an Id that is suitable as a primary key for most persistence systems.
    /// </summary>
    public interface IIdentifiable {
        long Id { get; }
    }
}