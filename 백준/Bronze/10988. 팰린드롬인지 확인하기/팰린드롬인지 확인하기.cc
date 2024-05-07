#include <iostream>

using namespace std;

int GetLength(char* str);

int main()
{
	char word[101];

	cin >> word;

	int wordLen = GetLength(word);

	for (int i = 0; i < wordLen; i++)
	{
		if (word[i] != word[wordLen - 1 - i])
		{
			cout << "0" << endl;
			return 0;
		}
	}

	cout << "1" << endl;

	return 0;
}

int GetLength(char* str)
{
	int cnt = 0;

	while (*str != '\0')
	{
		str++;
		cnt++;
	}

	return cnt;
}