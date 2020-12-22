using System;

namespace BOJ_C____
{
	class Program
	{
		static void Main(string[] args)
		{
			String line = Console.ReadLine();
			String[] numbers = line.Split();
			int a = int.Parse(numbers[0]);
			int b = int.Parse(numbers[1]);

			Console.WriteLine(a + b);
		}
	}
}