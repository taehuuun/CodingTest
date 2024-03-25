#include <iostream>

using namespace std;

void Sort(int* arr);

int main() 
{
	int dish[3];

	for (int i = 0; i < 3; i++)
	{
		cin >> dish[i];
	}

	Sort(dish);

	cout << dish[1] << endl;

	return 0;
}

void Sort(int* arr)
{
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 2 - i; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				int temp = arr[j];
				arr[j] = arr[j+ 1];
				arr[j + 1] = temp;
			}
		}
	}
}