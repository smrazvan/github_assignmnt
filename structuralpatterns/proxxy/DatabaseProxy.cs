using Blogger_server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxxy
{
    internal class DatabaseProxy : IDatabase
    {

        private Database _db;

        public DatabaseProxy(Database db)
        {
            _db = db;
        }
        private bool IsAuthorized()
        {
            return true;
        }
        public void AddPost(Post post)
        {
            if(IsAuthorized() && post.Author == "Mike")
            {
                _db.AddPost(post);
            } else
            {
                throw new Exception("user not authorized");
            }
        }


    }
}
