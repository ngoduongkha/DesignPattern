using Adapter.Interface;

namespace Adapter.Component {
    internal class SquareHole : ISquare {
        private readonly double _width;

        public SquareHole(double width) {
            _width = width;
        }

        public bool Fits(ISquare square) {
            return _width >= square.GetWidth();
        }

        public double GetWidth() {
            return _width;
        }
    }
}
