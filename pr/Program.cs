using pr;

internal class Program
{
	private static void Main(string[] args)
	{
		var food = new FoodProduct("apple", 1, DateTime.Today.AddDays(8));

		food.Consume();
	}
}