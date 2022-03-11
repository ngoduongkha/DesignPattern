namespace FactoryMethod.Product {
    class Plane : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Plane";
        }
    }
}
