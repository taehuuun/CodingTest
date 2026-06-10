#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    int arr[n][n];

    for(int x = 0; x < n; x++)
    {
        if(x % 2 == 0)
        {
            for(int y = 0; y < n; y++)
            {
                arr[y][x] = y + 1;
            }
        }
        else
        {
            for(int y = 0; y < n; y++)
            {
                arr[y][x] = n - y;
            }
        }
    }

    for(int y = 0; y < n; y++)
    {
        for(int x = 0; x < n; x++)
        {
            cout << arr[y][x];
        }

        cout << endl;
    }

    return 0;
}