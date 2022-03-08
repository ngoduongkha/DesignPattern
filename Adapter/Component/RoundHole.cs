using Adapter.Interface;

namespace Adapter.Component {
    internal class RoundHole : IRound {
        private readonly double _radius;

        public RoundHole(double radius) {
            _radius = radius;
        }

        public bool Fits(IRound round) {
            return _radius >= round.GetRadius();
        }

        public double GetRadius() {
            return _radius;
        }
    }
}
