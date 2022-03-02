using AbstractFactory.Product;

namespace AbstractFactory.Factory {
    class ModernFurnitureFactory : IFurnitureFactory {
        public IChair CreateChair() {
            return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable() {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa() {
            return new ModernSofa();
        }
    }
}
