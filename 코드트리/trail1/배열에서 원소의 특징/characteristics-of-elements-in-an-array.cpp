#include <iostream>
using namespace std;

int main() 
{
    int input, arr[10];

    for(int i = 0 ; i < 10; i++)
    {
        cin >> input;

        if(input % 3 == 0)
        {
            cout << arr[i-1];
            break;
        }

        arr[i] = input;
    }

    return 0;
}