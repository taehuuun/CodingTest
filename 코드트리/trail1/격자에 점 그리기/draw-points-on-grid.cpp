#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 9;
    int n, m, arr[MAX_SIZE][MAX_SIZE] = {}, order = 1;

    cin >> n >> m;

    for(int i = 0; i < m; i++)
    {
        int y, x;

        cin >> y >> x;

        arr[y-1][x-1] = order;
        order++;
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout << arr[i][j] << ' ';
        }

        cout << endl;
    }

    return 0;
}