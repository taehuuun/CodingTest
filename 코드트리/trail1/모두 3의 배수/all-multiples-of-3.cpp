#include <iostream>
using namespace std;

int main() 
{
    bool isMulOf3 = true;
    
    for(int i = 0; i < 5; i++)
    {
        int input;

        cin >> input;

        if(input % 3 != 0)
        {
            isMulOf3 = false;
            break;
        }
    }
    
    cout << (isMulOf3 ? 1 : 0);

    return 0;
}