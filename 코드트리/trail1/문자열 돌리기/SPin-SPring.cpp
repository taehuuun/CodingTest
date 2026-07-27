#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    cout << input << endl;

    int len = input.length();

    for(int i = 0; i < len; i++)
    {
        input = input.substr(len-1, 1) + input.substr(0, len - 1);

        cout << input << endl;
    }

    return 0;
}