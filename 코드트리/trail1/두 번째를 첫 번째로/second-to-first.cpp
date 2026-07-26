#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    char first = input[0], sec = input[1];

    for(int i = 0; i < input.length(); i++)
    {
        if(input[i] == sec)
        {
            input[i] = first;
        }
    }

    cout << input;

    return 0;
}