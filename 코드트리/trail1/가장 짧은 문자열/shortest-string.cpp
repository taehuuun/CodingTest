#include <iostream>
#include <string>
#include <climits>

using namespace std;

int main() 
{
    int minLen = INT_MAX, maxLen = INT_MIN;
    string input;

    for(int i = 0; i < 3; i++)
    {
        cin >> input;

        int len = input.length();

        if(maxLen < len)
        {
            maxLen = len;
        }

        if(minLen > len)
        {
            minLen = len;
        }
    }

    cout << maxLen - minLen;

    return 0;
}