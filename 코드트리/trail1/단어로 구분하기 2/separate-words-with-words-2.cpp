#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int row = 0;

    getline(cin, input);

    for(int i = 0; i < input.length(); i++)
    {
        if(input[i] == ' ')
        {
            if(row % 2 == 0)
            {
                cout << '\n';
            }
            row++;
        }
        else
        {
            if(row % 2 == 0)
            {
                cout << input[i];
            }
        }
    }

    return 0;
}