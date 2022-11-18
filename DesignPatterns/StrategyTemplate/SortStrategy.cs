using StrategyTemplate.SortStrategyTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    internal class SortStrategy: IFindMaxStrategy
    {
        public void FindMax(int[] arr)
        {
            var sorter = new QuickSorter();
            sorter.Sort();
        }
    }
}
