using Builder.Interface;

namespace Builder.Product {
    public class StoneHouseBuilder : IHouseBuilder {
        private House _house = new House();

        public StoneHouseBuilder() {
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

        public IHouseBuilder BuildWalls() {
            _house.Add("Stone Walls");
            return this;
        }

        public IHouseBuilder BuildDoors() {
            _house.Add("Stone Doors");
            return this;
        }

        public IHouseBuilder BuildWindows() {
            _house.Add("Stone Windows");
            return this;
        }

        public IHouseBuilder BuildRoof() {
            _house.Add("Stone Roof");
            return this;
        }
    }
}
