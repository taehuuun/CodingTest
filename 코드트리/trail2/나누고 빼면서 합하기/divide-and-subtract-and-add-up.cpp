#include <iostream>
using namespace std;

int GetSequenceSum(int arr[], int len, int m)
{
    int sum = 0;

    while(m)
    {
        sum += arr[m - 1];

        if(m % 2 == 0)
        {
            m /= 2;
        }
        else
        {
            m -= 1;
        }
    }

    return sum;
}

int main()
{
    const int MAX_SIZE = 100;
    int n, m, arr[MAX_SIZE], sum = 0;

    cin >> n >> m;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    cout << GetSequenceSum(arr, n, m);

    return 0;
}