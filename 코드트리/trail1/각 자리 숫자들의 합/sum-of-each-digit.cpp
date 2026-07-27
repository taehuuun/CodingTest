#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int result = 0;

    cin >> input;

    for(int i = 0 ; i < input.length(); i++)
    {
        result += input[i] - '0';
    }

    cout << result;

    return 0;
}