using NGame.Core;

namespace NGame.Base {
    public class Player : IPlayer {

        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}