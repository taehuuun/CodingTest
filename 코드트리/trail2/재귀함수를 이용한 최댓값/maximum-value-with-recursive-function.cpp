#include <iostream>
#include <climits>

using namespace std;

const int MAX_SIZE = 100;

int GetMaxNum(int *arr, int len, int idx, int max)
{
    if(idx >= len)
    {
        return max;
    }

    if(max < arr[idx])
    {
        max = arr[idx];
    }

    return GetMaxNum(arr, len, idx+1, max);
}

int main() 
{
    int n, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    cout << GetMaxNum(arr, n, 0, INT_MIN);

    return 0;
}