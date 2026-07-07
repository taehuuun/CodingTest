#include <iostream>
using namespace std;

int main() 
{
    int input;

    while(true)
    {
        cin >> input;

        if(input == 0)
        {
            break;
        }

        cout << input << endl;
    }

    return 0;
}