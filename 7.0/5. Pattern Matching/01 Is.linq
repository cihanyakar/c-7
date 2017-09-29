<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Console.WriteLine(Is("string"));
	Console.WriteLine(Is(5));
}

public static string Is(object obj)
{
	if (obj is string s)
	{
		return s;
	}
	return "ERROR";
}
