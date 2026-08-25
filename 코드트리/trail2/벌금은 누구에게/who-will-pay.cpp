#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 100;

    int n, m, k, arr[MAX_SIZE] = {}, first = -1;

    cin >> n >> m >> k;

    for(int i = 0; i < m; i++)
    {
        int penalty;

        cin >> penalty;

        arr[penalty - 1]++;

        if(arr[penalty-1] >= k)
        {
            first = penalty;
            break;
        }
    }

    cout << first;

    return 0;
}