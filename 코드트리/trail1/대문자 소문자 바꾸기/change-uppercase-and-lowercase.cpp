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
        cout << (islower(input[i]) ? (char)toupper(input[i]) : (char)tolower(input[i]));
    }

    return 0;
}