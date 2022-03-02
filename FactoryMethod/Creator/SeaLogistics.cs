using FactoryMethod.Product;

namespace FactoryMethod.Creator {
    class SeaLogistics : Logistics {
        public override ITransport FactoryMethod() {
            return new Ship();
        }

        public override string ToString() { return "Sea Logistics"; }
    }
}
