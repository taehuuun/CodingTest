#include <iostream>
using namespace std;

int main() 
{
    int n;

    while(true)
    {
        cin >> n;

        if(n < 25)
        {
            cout << "Higher" << endl;
        }
        else if(n > 25)
        {
            cout << "Lower" << endl;
        }
        else
        {
            cout << "Good" << endl;
            break;
        }
    }

    return 0;
}