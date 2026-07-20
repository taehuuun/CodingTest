#include <iostream>
#include <climits>
using namespace std;

int main() 
{
    const int MAX_SIZE = 10001;
    int n, input, findIdx, maxValue = INT_MIN, arr[MAX_SIZE], findArr[MAX_SIZE];

    cin >> n;
    findIdx = n;

    for(int i = 0 ; i < n; i++) 
    {
        cin >> arr[i];
    }

    while(findIdx != 0)
    {
        maxValue = INT_MIN;

        for(int i = 0 ; i < n; i++)
        {
            if(findArr[arr[i]] <= 1 && maxValue < arr[i] && i < findIdx)
            {
                maxValue = arr[i];
            }            
        }
    
        findArr[maxValue]++;

        for(int i = 0; i < n; i++)
        {
            if(maxValue == arr[i])
            {
                findIdx = i;
                cout << findIdx + 1 << " ";
                break;
            }
        }
    }

    return 0;
}