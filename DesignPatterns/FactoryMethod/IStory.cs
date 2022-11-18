using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal interface IStory
    {
        string Name { get; set; }
        int Pages { get; set; }

        void Read();
    }
}
