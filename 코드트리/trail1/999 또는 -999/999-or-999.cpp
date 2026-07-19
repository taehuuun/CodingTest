#include <iostream>
#include <climits>
using namespace std;

int main() 
{
    int input, min = INT_MAX, max = INT_MIN;

    while(true)
    {
        cin >> input;

        if(input == 999 || input == -999)
        {
            break;
        }

        if(input > max)
        {
            max = input;
        }

        if(input < min)
        {
            min = input;
        }
    }

    cout << max << " " << min;

    return 0;
}