namespace FactoryMethod.Product {
    class Train : ITransport {
        public string Deliver() {
            return "Deliver by train.";
        }
    }
}
