#include <iostream>
#include <algorithm>

using namespace std;

const int MAX_SIZE = 100;

int main() 
{
    int n, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 1 ; i <= n; i += 2)
    {
        int tmp[n];

        for(int j = 0; j < i; j++)
        {
            tmp[j] = arr[j];
        }

        sort(tmp, tmp + i);

        cout << tmp[i/2] << ' ';
    }

    return 0;
}