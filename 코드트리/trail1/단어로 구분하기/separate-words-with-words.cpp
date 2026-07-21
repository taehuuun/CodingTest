#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    getline(cin , input);

    for(int i = 0; i < input.length(); i++)
    {
        if(input[i] != ' ')
        {
            cout << input[i];
        }
        else
        {
            cout << '\n';
        }
    }

    return 0;
}