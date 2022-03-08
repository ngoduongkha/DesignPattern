namespace AbstractFactory.Product {
    public interface ISofa {
        string HasLegs();
        string SitOn();
        string ToString();
    }

    class ArtDecoSofa : ISofa {
        public string HasLegs() {
            return string.Format("{0} has four short legs.", ToString());
        }

        public string SitOn() {
            return string.Format("Sit on {0}.", ToString());
        }

        public override string ToString() {
            return "Art Deco Sofa";
        }
    }

    class VictorianSofa : ISofa {
        public string HasLegs() {
            return string.Format("{0} has four long legs.", ToString());
        }

        public string SitOn() {
            return string.Format("Sit on {0}.", ToString());
        }

        public override string ToString() {
            return "Victorian Sofa";
        }
    }

    class ModernSofa : ISofa {
        public string HasLegs() {
            return string.Format("{0} has no legs.", ToString());
        }

        public string SitOn() {
            return string.Format("Sit on {0}.", ToString());
        }

        public override string ToString() {
            return "Modern Sofa";
        }
    }
}