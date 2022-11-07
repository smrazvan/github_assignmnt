using System.Collections;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ionel = new User("ionel52");
            Console.WriteLine(Ionel.Username);
            var BestBlogger = new Writer("eminesku");
            BestBlogger.AddPost("first_post");
            foreach(string post in BestBlogger)
            {
                Console.WriteLine(post);
            }
            /* >>>> */ var NonAuthenticBlogger = (Writer)BestBlogger.Clone();
            foreach (string post in NonAuthenticBlogger)
            {
                Console.WriteLine(post);
            }
        }
    }
    //separate file
    public class User
    {
        public string FullName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string About { get; set; } = string.Empty;

        public virtual void presentFunction()
        {
            Console.WriteLine("I am a simple user");
        }
        //overloading constructor
        public User()
        {
        }
        public User(string username)
        {
            Username = username;
        }
        public User(string fullName, string username, string about)
        {
            FullName = fullName;
            Username = username;
            About = about;
        }
    }
    //separate file
    public class Writer : User, IEnumerable<string>, ICloneable
    {
        private List<string> posts = new List<string>();
        public void AddPost(string name)
        {
            posts.Add(name);
        }
        public override void presentFunction()
        {
            Console.WriteLine("I am a writer");
        }
        //implement IClonable
        public object Clone()
        {
            return (Writer)this.MemberwiseClone();
        }
        //implement IEnumerable
        public IEnumerator<string> GetEnumerator()
        {
            return posts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return posts.GetEnumerator();
        }

        public Writer() : base() { }
        public Writer(string username) : base(username) { }
        public Writer(string fullName, string username, string about) : base(fullName, username, about) { }
    }
}