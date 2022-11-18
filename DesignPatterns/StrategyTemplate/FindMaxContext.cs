using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    internal class FindMaxContext
    {
        private IFindMaxStrategy _strategy;

        public void SetStrategy(IFindMaxStrategy strategy)
        {
            _strategy = strategy;
        }

        public void FindMax(int[] arr)
        {
            if(_strategy == null)
            {
                Console.WriteLine("please select a strategy");
            } else
            {
                _strategy.FindMax(arr);
            }
        }
    }
}
