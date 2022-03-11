namespace AbstractFactory.Product {
    public interface IChair {
        string HasLegs();
        string SitOn();
        string ToString();
    }

    class ArtDecoChair : IChair {
        public string HasLegs() {
            return $"{ ToString() } has four short legs.";
        }

        public string SitOn() {
            return $"Sit on { ToString() }.";
        }

        public override string ToString() {
            return "Art Deco Chair";
        }
    }

    class VictorianChair : IChair {
        public string HasLegs() {
            return $"{ ToString() } has four long legs.";
        }

        public string SitOn() {
            return $"Sit on { ToString() }.";
        }

        public override string ToString() {
            return "Victorian Chair";
        }
    }
    class ModernChair : IChair {
        public string HasLegs() {
            return $"{ ToString() } has no legs.";
        }

        public string SitOn() {
            return $"Sit on { ToString() }.";
        }

        public override string ToString() {
            return "Modern Chair";
        }
    }
}
