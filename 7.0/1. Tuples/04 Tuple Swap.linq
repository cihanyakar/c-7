<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var a = 5;
	var b = 7;

	Console.WriteLine($"A = {a}");
	Console.WriteLine($"B = {b}");

	Console.ReadLine();
	
	#region Spoiler
	(a, b) = (b, a);
	#endregion

	Util.RawHtml("<hr />").Dump();
	Console.WriteLine($"A = {a}");
	Console.WriteLine($"B = {b}");
}

 