namespace FactoryMethod.Product {
    class Truck : ITransport {
        public string Deliver() {
            return string.Format("Deliver by {0}.", ToString());
        }

        public override string ToString() {
            return "Truck";
        }
    }
}
