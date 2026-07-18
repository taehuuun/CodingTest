#include <iostream>
#include <climits>
using namespace std;

int main() 
{
    int input, max = INT_MIN;

    for(int i = 0; i < 10; i++)
    {
        cin >> input;

        if(input > max)
        {
            max = input;
        }
    }

    cout << max;

    return 0;
}