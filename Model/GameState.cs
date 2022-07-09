using Game.Core;

namespace Game.Model {

    public class GameState : Identifiable, IGameState {
        public bool IsRunning { get; protected set; }

        public GameState() : base() {
            IsRunning = false;
        }
    }
}