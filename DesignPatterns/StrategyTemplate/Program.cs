

using StrategyTemplate;

string option = "sort";
var context = new FindMaxContext();

int[] arr = { 1, 2, 5, 7, 8, 4 };

if(option == "sort")
{
    context.SetStrategy(new SortStrategy());
    context.FindMax(arr);
}