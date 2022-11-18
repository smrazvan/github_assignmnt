using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate.SortStrategyTemplates
{
    public abstract class Sorter
    {
        public void Sort()
        {
            Console.WriteLine("Sorting has starte...");
            ReadingData();
            Sorting();
            OutputingData();
            Console.WriteLine("Array sorted...");
        }

        protected abstract void ReadingData();

        protected abstract void Sorting();

        protected abstract void OutputingData();
    }
}
