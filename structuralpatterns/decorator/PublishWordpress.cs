using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class PublishWordpress : AbstractDecorator
    {
        public PublishWordpress(AbstractBlog blog) : base(blog) { }

        public override string Publish()
        {
            return $"to wordpress, {base.Publish()}";
        }
    }
}
