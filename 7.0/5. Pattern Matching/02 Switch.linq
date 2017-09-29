<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Console.WriteLine(Switch("cihan"));
	Console.WriteLine(Switch(5));
	Console.WriteLine(Switch(5.7));
	Console.WriteLine(Switch(5.7M));
}

public static string Switch(object obj)
{
	switch (obj)
	{
		case string s:
			return "text :" + s;
		case int _: // discard
			return "integer number";
		case double b:
			return "binary floating point number";
		case decimal d:
			return "decimal floating point number";
	}
	return "unknown";
}