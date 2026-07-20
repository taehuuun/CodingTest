#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 100;
    int n, m, num = 0, arr[MAX_SIZE][MAX_SIZE];

    cin >> n >> m;

    for(int i = 0; i < m; i++)
    {
        if(i % 2 == 0)
        {
            for(int j = 0 ; j < n; j++)
            {
                arr[j][i] = num;
                num++;
            }
        }
        else
        {
            for(int j = n -1; j >= 0; j--)
            {
                arr[j][i] = num;
                num++;
            }
        }

    }

    for(int i = 0 ; i < n; i++)
    {
        for(int j = 0 ; j < m; j++)
        {
            cout << arr[i][j] << " ";
        }

        cout << endl;
    }

    return 0;
}