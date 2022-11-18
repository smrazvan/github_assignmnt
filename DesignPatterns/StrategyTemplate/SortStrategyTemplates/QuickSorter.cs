using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.SortStrategyTemplates
{
    internal class QuickSorter: Sorter
    {

        protected override void ReadingData()
        {
            Console.WriteLine("Reading data");
        }

        protected override void Sorting()
        {
            Console.WriteLine("Quicksorting");
        }

        protected override void OutputingData()
        {
            Console.WriteLine("Writing data");
        }
    }
}
