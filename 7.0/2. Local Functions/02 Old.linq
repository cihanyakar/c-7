<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public enum Operation
{
	Add,
	Divide
}

public static double CalculateOld(double a, double b, Operation operation)
{
	Func<double, double, double> add = (double number1, double number2) =>
									   {
										   return number1 + number2;
									   };

	Func<double, double, double> divide = (
	number1, number2) => number1 / number2;


	switch (operation)
	{
		case Operation.Add:
			return add(a, b);
		case Operation.Divide:
			return divide(a, b);
		default:
			return default(double);
	}

}

void Main()
{
	Console.WriteLine(CalculateOld(5, 5, Operation.Add));
}

