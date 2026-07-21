#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int len;

    cin >> input;
    cin >> len;

    if(len >= input.length())
    {
        for(int i = input.length()-1; i >= 0; i--)
        {
            cout << input[i];
        }
    }
    else
    {
        for(int i = input.length()-1; i >= input.length() - len; i--)
        {
            cout << input[i];
        }
    }

    return 0;
}