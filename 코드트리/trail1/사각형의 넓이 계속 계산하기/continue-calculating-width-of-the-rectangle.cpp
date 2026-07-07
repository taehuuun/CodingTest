#include <iostream>
using namespace std;

int main() 
{
    int a, b;
    char c;

    while(true)
    {
        cin >> a >> b >> c;

        cout << a * b << endl;

        if(c == 'C')
        {
            break;
        }
    }

    return 0;
}