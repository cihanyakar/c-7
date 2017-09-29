<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	if (int.TryParse(Console.ReadLine(), out int value))
	{
		Console.WriteLine(value * 2);
	}
	else
	{
		Console.WriteLine(default(int));
	}
}
