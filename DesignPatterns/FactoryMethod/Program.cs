using FactoryMethod;

int age = 11;

IStoryFactory factory;

if(age <= 13)
{
    factory = new FairytaleFactory();
} else
{
    factory = new NovelFactory();
}

IStory book = factory.CreateStory("The white princess", 10);

Console.WriteLine("Hello, World!");
