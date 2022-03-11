using Builder.Product;

namespace Builder.Builder {
    public abstract class HouseBuilder {
        protected House _house = new();

        public HouseBuilder() {
            Reset();
        }

        private void Reset() {
            _house = new House();
        }

        public House Build() {
            House result = _house;

            Reset();

            return result;
        }

        public abstract HouseBuilder BuildWalls();
        public abstract HouseBuilder BuildDoors();
        public abstract HouseBuilder BuildWindows();
        public abstract HouseBuilder BuildRoof();
        public abstract HouseBuilder BuildCeiling();
    }
}
