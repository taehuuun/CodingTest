#include <iostream>
using namespace std;

int main() 
{
    int input, oddSum = 0, evenSum = 0;

    for(int i = 1; i <= 10; i++)
    {
        cin >> input;

        if(i % 2 == 0)
        {
            evenSum += input;
        }
        else
        {
            oddSum += input;
        }
    }

    cout << (evenSum >= oddSum ? evenSum - oddSum : oddSum - evenSum);

    return 0;
}