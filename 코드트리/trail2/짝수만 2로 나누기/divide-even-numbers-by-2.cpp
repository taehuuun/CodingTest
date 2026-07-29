#include <iostream>
using namespace std;

void ModeOnlyEven(int *arr, int length)
{
    for(int i = 0; i < length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            arr[i] /= 2;
        }

        cout << arr[i] << " ";
    }
}

int main() 
{
    const int MAX_SIZE = 50;
    int n, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    ModeOnlyEven(arr, n);

    return 0;
}