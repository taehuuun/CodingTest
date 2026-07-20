#include <iostream>
#include <climits>

using namespace std;

int main() 
{
    const int MAX_SIZE = 11;
    int n, minDif = INT_MAX, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 0 ; i < n - 1; i++)
    {
        int dif = arr[i + 1] - arr[i];

        if(minDif > dif)
        {
            minDif = dif;
        }
    }

    cout << minDif;

    return 0;
}