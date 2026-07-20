#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 10;
    int n, arr[MAX_SIZE][MAX_SIZE], num = 1;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            arr[j][i] = num;
            num++;
        }
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}