#include <iostream>
#include <cmath>;

using namespace std;

int number[5];
int sum = 0;

int main()
{
    for(int i = 0 ; i <5; i++)
    {
        cin >> number[i];
    }

    for(int i = 0 ; i <5; i++)
    {
        sum += pow(number[i],2);
    }

    cout << sum%10;

    return 0;
}
