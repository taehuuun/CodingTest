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
        if(isdigit(input[i]) || !isalpha(input[i]))
        {
            continue;
        }

        cout << (char)toupper(input[i]);
    }

    return 0;
}