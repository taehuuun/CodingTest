#include <iostream>
#include <string>
using namespace std;

int main() 
{
    string input;
    int sum = 0;

    for(int i = 0 ; i < 2; i++)
    {
        cin >> input;
        sum += input.length();
    }

    cout << sum;

    return 0;
}