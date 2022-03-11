using Builder.Model;

namespace Builder.Product {
    public class ModernHouseBuilder : HouseBuilder {
        public override HouseBuilder BuildWalls() {
            _house.Add("Painted Walls");
            return this;
        }

        public override HouseBuilder BuildDoors() {
            _house.Add("Glass Doors");
            return this;
        }

        public override HouseBuilder BuildWindows() {
            _house.Add("Glass Windows");
            return this;
        }

        public override HouseBuilder BuildRoof() {
            _house.Add("Iron Roof");
            return this;
        }

        public override HouseBuilder BuildCeiling() {
            _house.Add("Cement Painted Ceiling");
            return this;
        }
    }
}
