#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    
    while(true)
    {
        cin >> input;

        if(input == "END")
        {
            break;
        }

        for(int i = input.length()-1; i >=0; i--)
        {
            cout << input[i];
        }

        cout << endl;
    }

    return 0;
}