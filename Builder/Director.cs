using Builder.Product;

namespace Builder {
    public class Director {
        private HouseBuilder _builder;

        public HouseBuilder Builder {
            set { _builder = value; }
        }

        public void BuildMinimalViableProduct() {
            _builder.BuildWalls()
                .BuildRoof()
                .BuildDoors();
        }

        public void BuildFullFeaturedProduct() {
            _builder.BuildWalls()
                .BuildCeiling()
                .BuildRoof()
                .BuildDoors()
                .BuildWindows();
        }
    }
}
