using System.Threading;
using Game.Core;

namespace Game.Model {

    public class Identifiable : IIdentifiable {

        private static long _instanceCounter = 0;

        public long Id { get; private set; }

        public Identifiable()
        {
            Id = Interlocked.Increment(ref _instanceCounter);
        }
    }
}