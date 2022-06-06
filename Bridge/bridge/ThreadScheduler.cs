using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    public abstract class ThreadScheduler
    {
        protected ThreadScheduler_Implementation thread;
        public ThreadScheduler(ThreadScheduler_Implementation thread)
        {
            this.thread = thread;
        }
        public abstract void Run();
    }
}
