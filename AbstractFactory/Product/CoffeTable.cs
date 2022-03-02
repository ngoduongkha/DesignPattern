namespace AbstractFactory.Product {
    public interface ICoffeeTable {
        string HasLegs();
        string PutOn();
        string ToString();
    }
    class ArtDecoCoffeeTable : ICoffeeTable {
        public string HasLegs() {
            return string.Format("{0} has four short legs.", ToString());
        }

        public string PutOn() {
            return string.Format("Put on {0}.", ToString());
        }

        public override string ToString() {
            return "Art Deco Coffee Table";
        }
    }

    class VictorianCoffeeTable : ICoffeeTable {
        public string HasLegs() {
            return string.Format("{0} has four long legs.", ToString());
        }

        public string PutOn() {
            return string.Format("Put on {0}.", ToString());
        }

        public override string ToString() {
            return "Victorian Coffee Table";
        }
    }

    class ModernCoffeeTable : ICoffeeTable {
        public string HasLegs() {
            return string.Format("{0} has no legs.", ToString());
        }

        public string PutOn() {
            return string.Format("Put on {0}.", ToString());
        }

        public override string ToString() {
            return "Modern Coffee Table";
        }
    }
}