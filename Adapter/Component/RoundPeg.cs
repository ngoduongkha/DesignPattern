using Adapter.Interface;

namespace Adapter.Component {
    internal class RoundPeg : IRound {
        private readonly double _radius;

        public RoundPeg(double radius) {
            _radius = radius;
        }

        public double GetRadius() {
            return _radius;
        }
    }
}