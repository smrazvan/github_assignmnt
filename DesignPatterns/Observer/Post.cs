using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Post
    {
        public Post(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public string Title { get; set; }

        public string Author { get; set; }
    }
}
