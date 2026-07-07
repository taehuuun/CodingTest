#include <iostream>
using namespace std;

int main() 
{
    int input;

    while(true)
    {
        cin >> input;

        if(input == 1)
        {
            cout << "John";
        }
        else if(input == 2)
        {
            cout << "Tom";
        }
        else if(input == 3)
        {
            cout << "Paul";
        }
        else if(input == 4)
        {
            cout << "Sam";
        }
        else
        {
            cout << "Vacancy";
            break;
        }

        cout << endl;
    }

    return 0;
}