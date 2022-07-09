using Game.Core;
using Game.Model;

namespace Game.Base {
    
    abstract class Game : GameState, IGameBehavior {
        
        public Game() : base() {}

        public async Task InitAsync() {
            await Task.Run(DoInit);
        }

        protected abstract void DoInit();

        public async Task StartAsync() {
            await Task.Run(DoStart);

            base.IsRunning = true;
        }

        /// <summary>
        /// Should implement basic starting procedure.
        /// E.g. Determining starting player etc.
        /// </summary>
        protected abstract void DoStart();

    }
}