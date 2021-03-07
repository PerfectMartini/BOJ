using System;

namespace BOJ
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] dab = new int[41, 2];
			dab[0, 0] = 1;
			dab[0, 1] = 0;
			dab[1, 0] = 0;
			dab[1, 1] = 1;

			for (int n = 2; n <= 40; n++)
			{
				dab[n, 0] = dab[n - 1, 0] + dab[n - 2, 0];
				dab[n, 1] = dab[n - 1, 1] + dab[n - 2, 1];
			}


			int T = int.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int N = int.Parse(Console.ReadLine());
				Console.WriteLine("{0} {1}", dab[N, 0], dab[N, 1]);
			}
		}
	}
}
