namespace AbstractFactory.Product {
    public interface ISofa {
        string HasLegs();
        string SitOn();
    }

    class ArtDecoSofa : ISofa {
        public string HasLegs() {
            return "Art Deco Sofa has four short legs.";
        }
        public string SitOn() {
            return "Sit on Art Deco Sofa.";
        }
    }

    class VictorianSofa : ISofa {
        public string HasLegs() {
            return "Victorian Sofa has four long legs.";
        }
        public string SitOn() {
            return "Sit on Victorian Sofa.";
        }
    }

    class ModernSofa : ISofa {
        public string HasLegs() {
            return "Modern Sofa has no legs.";
        }
        public string SitOn() {
            return "Sit on Modern Sofa.";
        }
    }
}