<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

public static (string, string) TupleDeclarationReturn()
{
	return ("Ankara", "06");
}

void Main()
{
	(var n, var p) = TupleDeclarationReturn();
	Console.WriteLine(n);
}
