#include <iostream>
using namespace std;

int main() 
{
    int arr[10] = {};
    int input = 0;

    for(int i = 0; i < 10; i++)
    {
        cin >> input;

        if(input == 0)
        {
            break;
        }

        arr[i] = input;
    }

    for(int i = 9; i >= 0; i--)
    {
        if(arr[i] == 0)
        {
            continue;
        }

        cout << arr[i] << " ";
    }

    return 0;
}