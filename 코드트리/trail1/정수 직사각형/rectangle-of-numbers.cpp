#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 101;
    int n, m, num = 1, arr[MAX_SIZE][MAX_SIZE];

    cin >> n >> m;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0 ; j < m; j++)
        {
            arr[i][j] = num;
            num++;
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0 ; j < m; j++)
        {
            cout << arr[i][j] << " ";
        }

        cout << endl;
    }

    return 0;
}