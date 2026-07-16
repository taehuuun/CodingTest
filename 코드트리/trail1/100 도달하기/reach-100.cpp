#include <iostream>
using namespace std;

int main() 
{
    int n, input, p, current, pp = 1;

    cin >> n;

    p = n;;

    cout << pp << " ";
    cout << p << " ";

    while(true)
    {
        current = pp + p;

        if(current > 100)
        {
            cout << current << " ";
            break;
        }

        cout << current << " ";

        pp = p;
        p = current;
    }

    return 0;
}