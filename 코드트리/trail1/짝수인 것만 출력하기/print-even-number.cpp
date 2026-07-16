#include <iostream>
using namespace std;

int main() 
{
    int n, input, idx = 0, arr[101];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> input;

        if(input % 2 == 0)
        {
            arr[idx] = input;
            idx++;
        }
    }

    for(int i = 0 ; i < idx; i++)
    {
        cout << arr[i] << " ";
    }

    return 0;
}