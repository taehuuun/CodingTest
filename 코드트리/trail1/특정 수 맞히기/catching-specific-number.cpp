#include <iostream>
using namespace std;

int main() 
{
    int input;

    while(true)
    {
        cin >> input;

        if(input == 25)
        {
            cout << "Good";
            break;
        }
        else if(input < 25)
        {
            cout << "Higher" << endl;
        }
        else if(input > 25)
        {
            cout << "Lower" << endl;
        }
    }

    return 0;
}