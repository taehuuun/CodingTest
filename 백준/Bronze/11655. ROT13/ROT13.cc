#include <iostream>
#include <string>

using namespace std;

string s;

int main()
{
	getline(cin, s);

	for (int i = 0; i < s.size(); i++)
	{
		if (islower(s[i]))
		{
			s[i] = (char)(s[i] + 13 > 'z' ? s[i] + 13 -26 : s[i]+13);
		}
		else if (isupper(s[i]))
		{
			s[i] = (char)(s[i] + 13 > 'Z' ? s[i] + 13 - 26 : s[i] + 13);
		}
	}

	cout << s;

	return 0;
}