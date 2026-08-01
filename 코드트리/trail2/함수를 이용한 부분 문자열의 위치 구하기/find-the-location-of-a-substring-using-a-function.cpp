#include <iostream>
#include <string>

using namespace std;

int GetStringStartIndex(string a, string b)
{
    int startIdx = -1;
    int totalLen = a.length() - b.length() + 1;

    for(int i = 0; i < totalLen; i++)
    {
        if(a[i] != b[0])
        {
            continue;
        }

        int cnt = 1;

        for(int j = 1; j < b.length(); j++)
        {
            if(a[i + j] != b[j])
            {
                break;
            }

            cnt++;
        }

        if(cnt == b.length())
        {
            startIdx = i;
            break;
        }
    }

    return startIdx;
}

int main()
{
    string str1, str2;

    cin >> str1 >> str2;

    cout << GetStringStartIndex(str1, str2);

    return 0;
}