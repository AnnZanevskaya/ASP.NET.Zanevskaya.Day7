using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Library
{
    

    public class ClockManager
    {
        public event EventHandler<TimeOverEventArgs> TimeOver;

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
