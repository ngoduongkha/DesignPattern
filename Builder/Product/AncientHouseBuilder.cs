using Builder.Model;

namespace Builder.Product {
    public class AncientHouseBuilder : HouseBuilder {
        public override HouseBuilder BuildWalls() {
            _house.Add("Stone Walls");
            return this;
        }

        public override HouseBuilder BuildDoors() {
            _house.Add("Wood Doors");
            return this;
        }

        public override HouseBuilder BuildWindows() {
            _house.Add("Wood Windows");
            return this;
        }

        public override HouseBuilder BuildRoof() {
            _house.Add("Tile Roof");
            return this;
        }

        public override HouseBuilder BuildCeiling() {
            _house.Add("Cement Roof");
            return this;
        }
    }
}
