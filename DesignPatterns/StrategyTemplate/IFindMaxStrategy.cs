using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTemplate
{
    internal interface IFindMaxStrategy
    {
        public void FindMax(int[] arr);
    }
}
