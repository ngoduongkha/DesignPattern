namespace AbstractFactory.Product {
    public interface IChair {
        string HasLegs();
        string SitOn();
        string ToString();
    }

    class ArtDecoChair : IChair {
        public string HasLegs() {
            return string.Format("{0} has four short legs.", ToString());
        }

        public string SitOn() {
            return string.Format("Sit on {0}.", ToString());
        }

        public override string ToString() {
            return "Art Deco Chair";
        }
    }

    class VictorianChair : IChair {
        public string HasLegs() {
            return string.Format("{0} has four long legs.", ToString());
        }

        public string SitOn() {
            return string.Format("Sit on {0}.", ToString());
        }

        public override string ToString() {
            return "Victorian Chair";
        }
    }
    class ModernChair : IChair {
        public string HasLegs() {
            return string.Format("{0} has no legs.", ToString());
        }

        public string SitOn() {
            return string.Format("Sit on {0}.", ToString());
        }

        public override string ToString() {
            return "Modern Chair";
        }
    }
}
