#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    char first = input[0], second = input[1];

    for(int i = 0; i < input.length(); i++)
    {
        if(input[i] == first)
        {
            input[i] = second;
        }
        else if(input[i] == second)        
        {
            input[i] = first;
        }
    }

    cout << input;

    return 0;
}