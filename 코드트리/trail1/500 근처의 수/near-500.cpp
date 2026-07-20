#include <iostream>
#include <climits>
using namespace std;

int main() 
{
    int input, minValue = INT_MAX, maxValue = INT_MIN;

    for(int i = 0; i < 10; i++)
    {
        cin >> input;

        if(input < 500)
        {
            if(maxValue < input)
            {
                maxValue = input;
            }
        }
        else if(input > 500)
        {
            if(minValue > input)
            {
                minValue = input;
            }
        }
    }

    cout << maxValue << " " << minValue;

    return 0;
}