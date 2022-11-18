using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class NovelFactory: IStoryFactory
    {
        public IStory CreateStory(string name, int pages)
        {
            return new Novel
            {
                Name = name,
                Pages = pages
            };
        }
    }
}
