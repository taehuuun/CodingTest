#include <iostream>
using namespace std;

int main() 
{
    int input, evenSum = 0, multipleOf3Sum = 0;

    for(int i = 0; i < 10; i++)
    {
        cin >> input;

        if((i-1) % 2 == 0)
        {
            evenSum += input;
        }

        if(i == 2 || i == 5 || i == 8)
        {
            multipleOf3Sum += input;
        }
    }

    cout << evenSum << " ";

    cout << fixed;
    cout.precision(1);

    cout << (float)multipleOf3Sum/3;

    return 0;
}