using Adapter.Component;
using Adapter.Interface;

namespace Adapter {
    internal class PegAdapter : IRound {
        private readonly SquarePeg _squarePeg;

        public PegAdapter(SquarePeg squarePeg) {
            _squarePeg = squarePeg;
        }

        public double GetRadius() {
            return _squarePeg.GetWidth() * System.Math.Sqrt(2) / 2;
        }
    }
}