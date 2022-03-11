namespace FactoryMethod.Product {
    class Car : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Car";
        }
    }
}
