#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int n, b, count = 0, arr[1000];

    cin >> n >> b;

    while(true)
    {
        if(n < b)
        {
            arr[count++] = n;
            break;
        }

        arr[count++] = n % b;
        n /= b;
    }

    for(int i = count - 1; i >= 0; i--)
    {
        cout << arr[i];
    }

    return 0;
}