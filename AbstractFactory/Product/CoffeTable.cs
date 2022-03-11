namespace AbstractFactory.Product {
    public interface ICoffeeTable {
        string HasLegs();
        string PutOn();
        string ToString();
    }

    class ArtDecoCoffeeTable : ICoffeeTable {
        public string HasLegs() {
            return $"{ ToString() } has four short legs.";
        }

        public string PutOn() {
            return $"Put on { ToString() }.";
        }

        public override string ToString() {
            return "Art Deco Coffee Table";
        }
    }

    class VictorianCoffeeTable : ICoffeeTable {
        public string HasLegs() {
            return $"{ ToString() } has four long legs.";
        }

        public string PutOn() {
            return $"Put on { ToString() }.";
        }

        public override string ToString() {
            return "Victorian Coffee Table";
        }
    }

    class ModernCoffeeTable : ICoffeeTable {
        public string HasLegs() {
            return $"{ ToString() } has no legs.";
        }

        public string PutOn() {
            return $"Put on { ToString() }.";
        }

        public override string ToString() {
            return "Modern Coffee Table";
        }
    }
}