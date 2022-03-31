namespace Singleton {
    internal class Singleton {
        private static Singleton _instance = new();
        private int _count = 0;

        private Singleton() {
        }

        public static Singleton GetInstance() {
            if (_instance == null) {
                _instance = new Singleton();
            }

            return _instance;
        }

        public int Count => _count;

        public void Increase() => _count++;
    }
}
