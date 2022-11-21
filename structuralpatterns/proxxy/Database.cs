using Blogger_server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxxy
{
    public class Database : IDatabase
    {
        public void AddPost(Post post)
        {
            Console.WriteLine($"{post.Title} has been added to database");
        }
    }
}
