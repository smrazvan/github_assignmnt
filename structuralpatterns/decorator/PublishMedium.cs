using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator
{
    public class PublishMedium : AbstractDecorator
    {
        public PublishMedium(AbstractBlog blog) : base(blog) { }

        public override string Publish()
        {
            return $"to medium, {base.Publish()}";
        }
    }
}
