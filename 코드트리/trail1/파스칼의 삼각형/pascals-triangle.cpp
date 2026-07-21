#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 15;
    int n, arr[MAX_SIZE][MAX_SIZE] = { };

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < i+1; j++)
        {
            arr[i][j] = 1;
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < i+1; j++)
        {
            if(j == 0 || j == i+1)
            {
                continue;
            }
            arr[i][j] = arr[i - 1][j-1] + arr[i-1][j];
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < i+1; j++)
        {
            cout << arr[i][j] << " ";
        }

        cout << endl;
    }

    return 0;
}