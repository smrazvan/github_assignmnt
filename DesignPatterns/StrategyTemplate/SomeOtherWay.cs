using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    internal class SomeOtherWay: IFindMaxStrategy
    {
        public void FindMax(int[] arr)
        {
            Console.WriteLine("array has been sorted");
        }
    }
}
