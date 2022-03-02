namespace FactoryMethod.Product {
    class Car : ITransport {
        public string Deliver() {
            return "Deliver by car.";
        }
    }
}
