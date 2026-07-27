#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main() 
{
    string input;
    int sum = 0;

    cin >> input;

    for(int i = 0; i < input.length(); i++)
    {
        if(!isdigit(input[i]))
        {
            continue;
        }

        sum += input[i] - '0';
    }

    cout << sum;

    return 0;
}