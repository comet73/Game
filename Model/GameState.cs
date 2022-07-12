using NGame.Core;

namespace NGame.Model {

    public enum State {
        None,
        Ready,
        Running,
        Terminated
    }

    public class GameState<TGameOptions, TPlayer> : IGameState<TGameOptions, TPlayer> 
        where TGameOptions : IGameOptions, new()
        where TPlayer : IPlayer 
    {
        protected TGameOptions Options { get; private set; }
        protected State State = State.None;
        protected IList<TPlayer> _players = new List<TPlayer>();

        public IEnumerable<TPlayer> Players => _players.AsEnumerable();

        public bool IsReady => State == State.Ready;

        public bool IsRunning => State == State.Running;

        public bool IsTerminated => State == State.Terminated;

        public GameState() : base() {
            Options = (TGameOptions)Activator.CreateInstance(typeof(TGameOptions));
        }

        public GameState(TGameOptions options) : base() {
            Options = options;
        }
    }
}