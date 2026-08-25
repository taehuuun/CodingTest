#include <iostream>
#include <climits>

using namespace std;

int main() 
{
    int n, t, maxLen = 0, currentLen = 0, prev = -1;

    cin >> n >> t;

    for(int i = 0; i < n; i++)
    {
        int input;

        cin >> input;

        if(input > t)
        {
            currentLen++;

            if(maxLen < currentLen)
            {
                maxLen = currentLen;
            }
        }
        else
        {
            currentLen = input > t ? 1 : 0;
        }

        prev = input;
    }

    cout << maxLen;

    return 0;
}