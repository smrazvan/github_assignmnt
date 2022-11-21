using Blogger_server.Entities;
using proxxy;


//only Mike is allowed to add to database
//var post = new Post() { Title = "How to make pasta", Author = "Mike" };
var post = new Post() { Title = "How to make pasta", Author = "Adina" };

var myProxy = new DatabaseProxy(new Database() { });
try
{
    myProxy.AddPost(post);
} catch
{
    Console.WriteLine("somethign went wrong..");
}
