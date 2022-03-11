namespace FactoryMethod.Product {
    class Truck : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Truck";
        }
    }
}
