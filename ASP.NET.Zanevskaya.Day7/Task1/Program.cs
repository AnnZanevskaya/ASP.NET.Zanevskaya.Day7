using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Library;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            Console.WriteLine("set time");
            time = Convert.ToInt32(Console.ReadLine());
            var clock = new ClockManager();
            var human = new Human(clock);
            var cooker = new Сooker(clock);
            cooker.Unregister(clock);
            
            clock.SimulateTimeOver(time);
        }
    }
}
