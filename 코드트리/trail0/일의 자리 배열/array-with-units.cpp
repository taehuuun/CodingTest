#include <iostream>
using namespace std;

int main() 
{
    int arr[10];
    int first, second;

    cin >> first >> second;

    arr[0] = first;
    arr[1] = second;

    for(int i = 2; i < 10; i++)
    {
        arr[i] = arr[i-2] + arr[i-1];
    }

    for(int i = 0; i < 10; i++)
    {
        cout << arr[i] % 10 << " ";
    }
    
    return 0;
}