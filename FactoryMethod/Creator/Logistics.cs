using FactoryMethod.Product;

namespace FactoryMethod.Creator {
    abstract class Logistics {
        public abstract ITransport CreateTransport();
        public abstract override string ToString();

        public string PlanDelivery() {
            var transport = CreateTransport();

            if (transport == null)
                return "No transportation was chosen!";

            return transport.Deliver();
        }
    }
}
