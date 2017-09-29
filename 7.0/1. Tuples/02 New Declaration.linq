<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var city = (Name: "Ankara", PlateNumber: "06");

	// var cityStruct = new ValueTuple<string, string>("Ankara", "06");
	// var cityClass = new Tuple<string, string>("Ankara", "06");

	Console.WriteLine(city.Name);
	TupleArgument(city);
	//TupleArgument2(city);
}

public static void TupleArgument((string, string) cityInfo)
{
	Console.WriteLine(cityInfo.Item2);
}

public static void TupleArgument2((string Name, string PlateNumber) cityInfo)
{
	Console.WriteLine(cityInfo.PlateNumber);
}