using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    class TimeOverEventArgs
    {
        public sealed class TimeOverEventArgs : EventArgs
        {
            private readonly int timeRequired;

            public TimeOverEventArgs(int time)
            {
                timeRequired = time;
            }

            public int Time { get { return timeRequired; } }
        }
    }
}
