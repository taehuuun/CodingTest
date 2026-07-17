#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 101;
    int n, arr[MAX_SIZE], count = 0;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 0 ; i < n; i++)
    {
        if(arr[i] == 2)
        {
            count++;
        }

        if(count == 3)
        {
            cout << i+1;
            break;
        }
    }

    return 0;
}