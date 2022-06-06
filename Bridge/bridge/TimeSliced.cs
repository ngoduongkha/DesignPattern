using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class TimeSliced : ThreadScheduler
    {
        public TimeSliced(ThreadScheduler_Implementation thread): base(thread) { }

        public override void Run()
        {
            Console.WriteLine("TimeSliced  " + thread.setSystem());
        }
    }
}
