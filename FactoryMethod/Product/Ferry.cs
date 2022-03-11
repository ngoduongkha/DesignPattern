namespace FactoryMethod.Product {
    class Ferry : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Ferry";
        }
    }
}
