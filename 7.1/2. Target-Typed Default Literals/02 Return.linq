<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Console.WriteLine(Parse("5"));
}

public static int Parse(string text)
{
	if (int.TryParse(text, out int i))
	{
		return i;
	}
	return default;
}