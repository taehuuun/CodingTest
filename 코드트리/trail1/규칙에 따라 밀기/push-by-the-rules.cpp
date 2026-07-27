#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input, command;

    cin >> input >> command;

    int commandLen = command.length(), inputLen = input.length();

    for(int i = 0; i < commandLen; i++)
    {
        if(command[i] == 'L')
        {
            input = input.substr(1, inputLen-1) + input.substr(0, 1);
        }
        else
        {
            input = input.substr(inputLen-1, 1) + input.substr(0, inputLen - 1);
        }
    }

    cout << input;

    return 0;
}