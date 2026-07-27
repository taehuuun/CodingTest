#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    for(int i = 0; i < input.length(); i++)
    {
        if(input[i] == 'e')
        {
            input.erase(i, 1);
            break;
        }
    }

    cout << input;

    return 0;
}