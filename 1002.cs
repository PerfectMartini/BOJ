using System;

namespace BOJ
{
	class Program
	{
		static void Main(string[] args)
		{
			int T = int.Parse(Console.ReadLine());
			while (T-- > 0) 
			{
				String line = Console.ReadLine();
				String[] numbers = line.Split();
				int x1 = int.Parse(numbers[0]);
				int y1 = int.Parse(numbers[1]);
				int r1 = int.Parse(numbers[2]);
				int x2 = int.Parse(numbers[3]);
				int y2 = int.Parse(numbers[4]);
				int r2 = int.Parse(numbers[5]);
				int d = (x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2); 

				int dab = 0;

				if (x1 == x2 && y1 == y2 && r1 == r2)
				{
					dab = -1;
				}
				else if (d == (r1 + r2) * (r1 + r2))
				{
					dab = 1;
				}
				else if (d == (r1 - r2)*(r1 - r2))
				{
					dab = 1;
				}
				else if (d > (r1 + r2)*(r1 + r2))
				{
					dab = 0;
				}
				else if (d < (r1 - r2) * (r1 - r2))
				{
					dab = 0;
				}
				else
				{
					dab = 2;
				}

				Console.WriteLine(dab);
			}

		}
	}
}
