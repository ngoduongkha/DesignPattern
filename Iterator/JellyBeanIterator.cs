using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator {
    interface IJellyBeanIterator {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentBean { get; }
    }
    internal class JellyBeanIterator : IJellyBeanIterator {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public JellyBeanIterator(JellyBeanCollection beans) {
            this._jellyBeans = beans;
        }

        // Gets first jelly bean
        public JellyBean First() {
            _current = 0;
            return _jellyBeans[_current] as JellyBean;
        }

        // Gets next jelly bean
        public JellyBean Next() {
            _current += _step;
            if (!IsDone)
                return _jellyBeans[_current] as JellyBean;
            else
                return null;
        }

        public JellyBean CurrentBean {
            get { return _jellyBeans[_current] as JellyBean; }
        }

        public bool IsDone {
            get { return _current >= _jellyBeans.Count; }
        }
    }
}
