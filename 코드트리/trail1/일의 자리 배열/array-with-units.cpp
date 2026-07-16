#include <iostream>
using namespace std;

int main() 
{
    int pp, p, arr[10];

    cin >> pp >> p;

    arr[0] = pp;
    arr[1] = p;

    for(int i = 2; i < 10; i++)
    {
        arr[i] = (arr[i-1] + arr[i-2]) % 10;
    }

    for(int i = 0 ; i < 10; i++)
    {
        cout << arr[i] << " ";
    }

    return 0;
}