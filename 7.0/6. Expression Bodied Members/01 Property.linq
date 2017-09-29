<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var o = new Sample(5);
	Console.WriteLine(o.Value);
	o.AddOne();
	
	Console.WriteLine(o.Value);

}

public class Sample
{
	private static int _value;
	public Sample(int value)
	{
		_value = value;
	}


	public void AddOne() => _value += 1;

	//public int Value
	//{
	//    get
	//    {
	//        return _value;

	//    }
	//}

	public int Value => _value;
}