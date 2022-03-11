namespace AbstractFactory.Product {
    public interface ISofa {
        string HasLegs();
        string SitOn();
        string ToString();
    }

    class ArtDecoSofa : ISofa {
        public string HasLegs() {
            return $"{ ToString() } has four short legs.";
        }

        public string SitOn() {
            return $"Sit on { ToString() }.";
        }

        public override string ToString() {
            return "Art Deco Sofa";
        }
    }

    class VictorianSofa : ISofa {
        public string HasLegs() {
            return $"{ ToString() } has four long legs.";
        }

        public string SitOn() {
            return $"Sit on { ToString() }.";
        }

        public override string ToString() {
            return "Victorian Sofa";
        }
    }

    class ModernSofa : ISofa {
        public string HasLegs() {
            return $"{ ToString() } has no legs.";
        }

        public string SitOn() {
            return $"Sit on { ToString() }.";
        }

        public override string ToString() {
            return "Modern Sofa";
        }
    }
}