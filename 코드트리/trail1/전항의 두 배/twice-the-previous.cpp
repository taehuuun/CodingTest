#include <iostream>
using namespace std;

int main() 
{
    int pp, p , current = 0;

    cin >> pp >> p;

    cout << pp << ' ' << p << ' ';

    for(int i = 2; i < 10; i++)
    {
        current = 2 * pp + p;

        cout << current << ' ';

        pp = p;
        p = current;
    }

    return 0;
}