<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public enum Operation
{
	Add,
	Divide
}
delegate double OperationDelegate(double number1, double number2);
public static double CalculateAncient(double a, double b, Operation operation)
{
	OperationDelegate add = delegate (double number1, double number2)
							{
								return number1 + number2;
							};

	OperationDelegate divide = (number1, number2) => number1 / number2;

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
	Console.WriteLine(CalculateAncient(5, 5, Operation.Add));
}


