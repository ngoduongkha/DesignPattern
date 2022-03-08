using FactoryMethod.Product;

namespace FactoryMethod.Creator {
    class RailLogistics : Logistics {
        public override ITransport CreateTransport() {
            return new Train();
        }

        public override string ToString() { return "Rail Logistics"; }
    }
}
