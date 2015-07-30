using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Library
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

    public class ClockManager
    {
        public event EventHandler<TimeOverEventArgs> TimeOver = delegate {};

        protected virtual void OnTimeOver(TimeOverEventArgs e)
        {
            EventHandler<TimeOverEventArgs> temp = TimeOver;
             if (temp != null)
            {
                temp(this, e);
            }
        }
        public void SimulateTimeOver(int time)
        {
            Thread.Sleep(time);
            OnTimeOver(new TimeOverEventArgs(time));
        }
    }


}
