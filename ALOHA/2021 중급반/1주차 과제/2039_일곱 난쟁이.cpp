#include <iostream>
#include <algorithm>
using namespace std;

int ki[9 + 1];
int sum_ki;

int main(void)

{
	for ( int i = 1; i <= 9; i++ )
	{
		cin >> ki[i];
		sum_ki += ki[i];
	}

	for ( int i = 1; i <= 9; i++ )
	{
		for ( int j = 1; j <= 9; j++ )
		{
			if ( i == j ) continue;

			if ( sum_ki - ki[i] - ki[j] == 100 )
			{
				ki[i] = ki[j] = 0;

				sort(ki, ki + 10);

				for ( int k = 3; k <= 9; k++ )
				{
					cout << ki[k] << '\n';
				}
				return 0;
			}
		}
	}

	return 0;
}