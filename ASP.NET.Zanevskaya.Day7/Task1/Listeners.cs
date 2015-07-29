using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Library;

namespace Task1
{
    public sealed class Human
    {
        public Human(ClockManager time)
        {
            time.TimeOver += HumanMsg;
        }
        private void HumanMsg(Object sender, TimeOverEventArgs eventArgs)
        {
            Console.WriteLine("Time over");
            Console.WriteLine("time set = {0}", eventArgs.Time);
        }
        public void Unregister(ClockManager time)
        {
            time.TimeOver -= HumanMsg;
        }
    }
    public sealed class Сooker
    {
        public Сooker(ClockManager clock)
        {
            clock.TimeOver += СookerMsg;
        }
        private void СookerMsg(Object sender, TimeOverEventArgs eventArgs)
        {
            Console.WriteLine("Time over");
            Console.WriteLine("time set = {0}", eventArgs.Time);
        }
        public void Unregister(ClockManager clock)
        {
            clock.TimeOver -= СookerMsg;
        }
    }
}
