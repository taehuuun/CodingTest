#include <iostream>
using namespace std;

int main() 
{
    int n, m;

    cin >> n >> m;

    int arr1[n][m];
    int arr2[n][m];

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            cin >> arr1[i][j];
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            cin >> arr2[i][j];
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            if(arr1[i][j] != arr2[i][j])
            {
                cout << "1 ";
            }
            else
            {
                cout << "0 ";
            }

        }
        cout << endl;
    }

    return 0;
}