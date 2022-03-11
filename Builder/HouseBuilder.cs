namespace Builder {
    public interface IHouseBuilder {
        HouseBuilder BuildWalls();
        HouseBuilder BuildDoors();
        HouseBuilder BuildWindows();
        HouseBuilder BuildRoof();
        HouseBuilder BuildGarage();
        House Build();
    }

    public class HouseBuilder : IHouseBuilder {
        private House _house = new House();

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

        public HouseBuilder BuildWalls() {
            _house.Add("Walls");
            return this;
        }

        public HouseBuilder BuildDoors() {
            _house.Add("Doors");
            return this;
        }

        public HouseBuilder BuildWindows() {
            _house.Add("Windows");
            return this;
        }

        public HouseBuilder BuildRoof() {
            _house.Add("Roof");
            return this;
        }

        public HouseBuilder BuildGarage() {
            _house.Add("Garage");
            return this;
        }
    }
}
