#include <iostream>
#include <climits>

using namespace std;

int main()
{
    int n, maxLen = INT_MIN, prev = 0, currentLen = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int input;

        cin >> input;

        if(i == 0)
        {
            currentLen++;
        }
        else
        {
            if(prev < input)
            {
                currentLen++;
            }
            else
            {
                currentLen = 1;
            }
        }

        if(maxLen < currentLen)
        {
            maxLen = currentLen;
        }
        
        prev = input;
    }

    cout << maxLen;

    return 0;
}