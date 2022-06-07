using System.Collections;

namespace Iterator {
    interface ICandyCollection {
        IJellyBeanIterator CreateIterator();
    }

    internal class JellyBeanCollection : ICandyCollection {
        private readonly ArrayList _items = new();

        public IJellyBeanIterator CreateIterator() {
            return new JellyBeanIterator(this);
        }

        public int Count {
            get { return _items.Count; }
        }

        public object this[int index] {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
