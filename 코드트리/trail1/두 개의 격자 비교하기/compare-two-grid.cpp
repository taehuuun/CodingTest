#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 10;
    int n, m, a[MAX_SIZE][MAX_SIZE], b[MAX_SIZE][MAX_SIZE];

    cin >> n >> m;

    for(int i = 0 ; i < n; i++)
    {
        for(int j = 0 ; j < m; j++)
        {
            cin >> a[i][j];
        }
    }

    for(int i = 0 ; i < n; i++)
    {
        for(int j = 0 ; j < m; j++)
        {
            cin >> b[i][j];
        }
    }

    for(int i = 0 ; i < n; i++)
    {
        for(int j = 0 ; j < m; j++)
        {
            cout << (a[i][j] == b[i][j] ? 0 : 1) << " ";
        }

        cout << endl;
    }

    return 0;
}