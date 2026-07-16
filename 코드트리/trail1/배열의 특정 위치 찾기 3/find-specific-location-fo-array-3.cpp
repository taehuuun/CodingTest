#include <iostream>
using namespace std;

int main() 
{
    int input, zeroIdx, sum = 0, arr[101];

    for(int i = 0 ; i < 100; i++)
    {
        cin >> arr[i];

        if(arr[i] == 0)
        {
            zeroIdx = i;
            break;
        }
    }

    for(int i = zeroIdx - 3; i < zeroIdx; i++)
    {
        sum += arr[i];
    }

    cout << sum;

    return 0;
}