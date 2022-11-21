// See https://aka.ms/new-console-template for more information


using decorator;
string defaultText = "Your blog has been posted to the following platforms:";
var CookingBlog = new Blog { };
Console.WriteLine(defaultText + CookingBlog.Publish());

var CookingBlogWMedium = new PublishMedium(CookingBlog);
Console.WriteLine(defaultText + CookingBlogWMedium.Publish());

var CookingBlogWMediumWordPress = new PublishWordpress(CookingBlogWMedium);
Console.WriteLine(defaultText + CookingBlogWMediumWordPress.Publish());