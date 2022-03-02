using FactoryMethod.Product;

namespace FactoryMethod.Creator {
    class AirLogistics : Logistics {
        public override ITransport FactoryMethod() {
            return new Plane();
        }

        public override string ToString() { return "Air Logistics"; }
    }
}
