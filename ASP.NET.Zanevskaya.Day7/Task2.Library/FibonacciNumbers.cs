using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
   public class FibonacciNumbers
    {
       public static IEnumerable<int> GetFibbonacciNumbers(int nNumbers) 
       {
           int prevN = 0;
           int currentN = 1;
           yield return currentN;
           for (int i = 0; i < nNumbers - 1; i++)
			{
               int tempN = currentN;
               currentN = currentN + prevN;
               prevN = tempN;
			   yield return currentN;
			}
       }
   } 
}
