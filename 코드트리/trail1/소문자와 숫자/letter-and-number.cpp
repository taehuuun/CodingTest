#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    for(int i = 0; i < input.length(); i++)
    {
        if(!isalpha(input[i]) && !isdigit(input[i]))
        {
            continue;
        }

        cout << (char)tolower(input[i]);
    }

    return 0;
}