#include <iostream>
using namespace std;

int main() 
{
    int input, arr[101];

    while(true)
    {
        cin >> input;

        if(input == 0)
        {
            break;
        }

        if(input % 2 == 0)
        {
            cout << input / 2;
        }
        else
        {
            cout << input + 3;
        }

        cout << " ";
    }

    return 0;
}