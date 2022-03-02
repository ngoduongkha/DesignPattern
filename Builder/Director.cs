namespace Builder {
    public class Director {
        private IHouseBuilder _builder;

        public IHouseBuilder Builder {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct() {
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.BuildDoors();
        }

        public void BuildFullFeaturedProduct() {
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.BuildDoors();
            _builder.BuildWindows();
            _builder.BuildGarage();
        }
    }
}
