#include <iostream>
#include <string>

using namespace std;

bool IsPalindrome(string str)
{
    for(int i = 0; i < str.length() / 2; i++)
    {
        if(str[i] != str[str.length() - 1 - i])
        {
            return false;
        }
    }

    return true;
}

int main() 
{
    string input;
    cin >> input;

    cout << (IsPalindrome(input) ? "Yes" : "No");

    return 0;
}