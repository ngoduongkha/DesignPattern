namespace Prototype {
    internal class ColorManager {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key] {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
