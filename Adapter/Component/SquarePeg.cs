using Adapter.Interface;

namespace Adapter.Component {
    public class SquarePeg : ISquare {
        private readonly double _width;

        public SquarePeg(double width) {
            _width = width;
        }

        public double GetWidth() {
            return _width;
        }
    }
}