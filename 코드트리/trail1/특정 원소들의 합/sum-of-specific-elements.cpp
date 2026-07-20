#include <iostream>
using namespace std;

int main() 
{
    int sum = 0, arr[4][4];

    for(int i = 0 ; i < 4; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            cin >> arr[i][j];
        }
    }

    for(int i = 0 ; i < 4; i++)
    {
        for(int j = 0; j < i + 1; j++)
        {
            sum += arr[i][j];
        }
    }

    cout << sum;

    return 0;
}