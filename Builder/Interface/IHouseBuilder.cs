namespace Builder {
    public interface IHouseBuilder {
        IHouseBuilder BuildWalls();
        IHouseBuilder BuildDoors();
        IHouseBuilder BuildWindows();
        IHouseBuilder BuildRoof();
        House Build();
    }

    public class WoodHouseBuilder : IHouseBuilder {
        private House _house = new House();

        public WoodHouseBuilder() {
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
            _house.Add("Wood Walls");
            return this;
        }

        public IHouseBuilder BuildDoors() {
            _house.Add("Wood Doors");
            return this;
        }

        public IHouseBuilder BuildWindows() {
            _house.Add("Wood Windows");
            return this;
        }

        public IHouseBuilder BuildRoof() {
            _house.Add("Wood Roof");
            return this;
        }
    }
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
