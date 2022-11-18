using Observer;

//publisher
Blog cookingBlog = new Blog();

//subscribers
var jason = new User("Jason");
var joe = new User("Joe");
var johanna = new User("Johanna");

cookingBlog.AddFollower(jason);
cookingBlog.AddFollower(joe);
cookingBlog.AddFollower(johanna);

cookingBlog.Publish(new Post("How to make pasta", "Mihai"));