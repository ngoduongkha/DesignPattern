namespace FactoryMethod.Product {
    class Train : ITransport {
        public string Deliver() {
            return $"Deliver by { ToString() }.";
        }

        public override string ToString() {
            return "Train";
        }
    }
}
