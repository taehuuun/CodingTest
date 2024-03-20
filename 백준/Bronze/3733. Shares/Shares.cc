#include <iostream>

using namespace std;

int main()
{
	int n;

	while (cin >> n)
	{
		int x;

		cin >> x;

		cout << x / (n + 1) << endl;
	}

	return 0;
}