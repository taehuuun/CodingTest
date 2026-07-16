#include <iostream>
using namespace std;

int main() 
{
    int arr[101];
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = n - 1; i >= 0; i--)
    {
        int current = arr[i];

        if(current % 2 == 0)
        {
            cout << current << " ";
        }
    }

    return 0;
}