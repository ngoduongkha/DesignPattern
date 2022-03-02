using FactoryMethod.Product;

namespace FactoryMethod.Creator {
    abstract class Logistics {
        public abstract ITransport FactoryMethod();
        public abstract string ToString();

        public string PlanDelivery() {
            var transport = FactoryMethod();

            if (transport == null)
                return "No transportation was chosen!";

            return transport.Deliver();
        }
    }
}
