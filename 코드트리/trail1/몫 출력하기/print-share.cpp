#include <iostream>
using namespace std;

int main() 
{
    int input, count = 0;

    while(true)
    {
        cin >> input;
        
        if(count == 3)
        {
            break;
        }

        if(input % 2 == 0)
        {
            input /= 2;
            cout << input << endl;
            count++;
        }
    }

    return 0;
}