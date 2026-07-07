#include <iostream>
using namespace std;

int main() 
{
    int a, b, c;
    bool isFind = false;

    cin >> a >> b >> c;

    for(int i = a; i <= b; i++)
    {
        if(i % c == 0)
        {
            isFind = true;
            break;
        }
    }

    cout << (isFind ? "YES" : "NO");

    return 0;
}