#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input, result;

    cin >> input;

    for(int i = 0 ; i < input.length(); i++)
    {
        if((i+1) % 2 == 0)
        {
            result += input[i];
        }
    }

    for(int i = result.length() - 1; i >= 0; i--)
    {
        cout << result[i];
    }

    return 0;
}