#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input, arr[10];
    int idx = 0;

    getline(cin, input);

    for(int i = 0; i < input.length(); i++)
    {
        if(input[i] == ' ')
        {
            idx++;
        }
        else
        {
            arr[idx] += input[i];
        }
    }

    for(int i = 9; i >= 0; i--)
    {
        cout << arr[i] << endl;
    }

    return 0;
}