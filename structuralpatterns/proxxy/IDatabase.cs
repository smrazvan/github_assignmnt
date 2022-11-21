using Blogger_server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxxy
{
    internal interface IDatabase
    {
        public void AddPost(Post post);
    }
}
