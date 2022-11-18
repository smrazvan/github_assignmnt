using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Novel: IStory
    {
        public string Name { get; set; }

        public int Pages { get; set; }

        public void Read()
        {
            Console.WriteLine("reading novel");
        }
    }
}
