#include <iostream>
using namespace std;

int main() 
{
    int mulOfThree = 0;
    int mulOfFive = 0;

    for(int i = 0 ; i < 10; i++)
    {
        int input;
        cin >> input;

        if(input % 3 == 0)
        {
            mulOfThree++;
        }
        
        if(input % 5 == 0)
        {
            mulOfFive++;
        }
    }

    cout << mulOfThree << " " << mulOfFive;

    return 0;
}