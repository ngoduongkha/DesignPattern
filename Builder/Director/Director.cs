using Builder.Builder;

namespace Builder.Director {
    public class HouseDirector {
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
