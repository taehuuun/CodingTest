#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 1001;
    int n, input, arr[MAX_SIZE] = { }, max = -1;

    cin >> n;

    for(int i = 0 ; i < n; i++) 
    {
        cin >> input;

        arr[input]++;
    }

    for(int i = 0 ; i < MAX_SIZE; i++)
    {

        if(arr[i] != 1)
        {
            continue;
        }

        if(max < i)
        {
            max = i;
        }
    }

    cout << max;

    return 0;
}