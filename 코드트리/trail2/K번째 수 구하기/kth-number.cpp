#include <iostream>
#include <algorithm>

using namespace std;

const int MAX_SIZE = 1000;

int main()
{
    int n, k, arr[MAX_SIZE];

    cin >> n >> k;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    sort(arr, arr + n);

    cout << arr[k-1];

    return 0;
}