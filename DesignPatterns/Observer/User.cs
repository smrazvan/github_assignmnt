using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class User: ISubscriber<Post>
    {
        public User(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public void Notify(Post post)
        {
            Console.WriteLine($"Hello, {Name}! \nA new post named {post.Title} by {post.Author}");
        }
    }
}
