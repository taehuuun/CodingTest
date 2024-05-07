#include <iostream>

using namespace std;

int n, patternIdx;
string pattern;
string leftPattern;
string rightPattern;

int main()
{
	cin >> n;
	cin >> pattern;

	patternIdx = pattern.find('*');
	leftPattern = pattern.substr(0, patternIdx);
	rightPattern = pattern.substr(patternIdx + 1);

	for (int i = 0; i < n; i++)
	{
		string str;
		cin >> str;

		if (leftPattern.size() + rightPattern.size() > str.size())
		{
			cout << "NE" << endl;
			continue;
		}

		if (str.substr(0, leftPattern.size()) == leftPattern && str.substr(str.size() - rightPattern.size()) == rightPattern)
		{
			cout << "DA" << endl;
		}
		else
		{
			cout << "NE" << endl;
		}
	}


	return 0;
}