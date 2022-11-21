using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class Blog : AbstractBlog
    {
        public override string Publish()
        {
            return "to Bloggr";
        }
    }
}
