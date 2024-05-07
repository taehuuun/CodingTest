#include <iostream>

using namespace std;

int timeLine[101];
int a, b, c;
int totalCost;

int main()
{
	cin >> a >> b >> c;

	for (int i = 0; i < 3; i++)
	{
		int start, end = 0;
		cin >> start >> end;

		for (int j = start; j < end; j++)
		{
			timeLine[j]++;
		}
	}

	for (int i = 0; i < 101; i++)
	{
		if (timeLine[i] == 0)
		{
			continue;
		}

		switch (timeLine[i])
		{
		case 1:
			totalCost += timeLine[i] * a;
			break;
		case 2:
			totalCost += timeLine[i] * b;
			break;
		case 3:
			totalCost += timeLine[i] * c;
			break;
		}

	}

	cout << totalCost;

	return 0;
}