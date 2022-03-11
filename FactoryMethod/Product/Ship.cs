namespace FactoryMethod.Product {
    class Ship : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Ship";
        }
    }
}
