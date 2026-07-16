#include <iostream>
using namespace std;

int main() 
{
    char input;

    for(int i = 0 ; i < 10; i++)
    {
        cin >> input;

        if(i == 1 || i == 4 || i == 7)
        {
            cout << input << " ";
        }
    }

    return 0;
}