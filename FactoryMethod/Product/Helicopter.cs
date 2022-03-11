namespace FactoryMethod.Product {
    class Helicopter : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Helicopter";
        }
    }
}
