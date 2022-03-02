namespace Builder {
    public interface IHouseBuilder {
        void BuildWalls();
        void BuildDoors();
        void BuildWindows();
        void BuildRoof();
        void BuildGarage();
        House GetHouse();
    }

    public class HouseBuilder : IHouseBuilder {
        private House _house = new House();

        public HouseBuilder() {
            Reset();
        }

        public void Reset() {
            _house = new House();
        }

        public House GetHouse() {
            House result = _house;

            Reset();

            return result;
        }

        public void BuildWalls() {
            _house.Add("Walls");
        }

        public void BuildDoors() {
            _house.Add("Doors");
        }

        public void BuildWindows() {
            _house.Add("Windows");
        }

        public void BuildRoof() {
            _house.Add("Roof");
        }

        public void BuildGarage() {
            _house.Add("Garage");
        }
    }
}
