<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var array = new[]
			{
				5, 10, 15, 20, 25
			};

	Console.WriteLine(array[0]);
	Console.WriteLine(array[1]);
	Console.WriteLine(array[2]);
	Console.WriteLine(array[3]);
	Console.WriteLine(array[4]);
	
	ref int max = ref BiggestItem(array);
	max = 78;
	Console.ReadLine();
	
	Console.WriteLine(array[0]);
	Console.WriteLine(array[1]);
	Console.WriteLine(array[2]);
	Console.WriteLine(array[3]);
	Console.WriteLine(array[4]);
}

public static ref int BiggestItem(int[] array)
{
	int maxIndex= 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > array[maxIndex])
		{
			 maxIndex = i;
		}
	}
	return ref array[maxIndex];
}