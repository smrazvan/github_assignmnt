using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public abstract class AbstractDecorator : AbstractBlog
    {
        protected AbstractBlog _blog;

        public AbstractDecorator(AbstractBlog blog)
        {
            _blog = blog;
        }
        
        public override string Publish()
        {
            return _blog.Publish();
        }
    }
}
