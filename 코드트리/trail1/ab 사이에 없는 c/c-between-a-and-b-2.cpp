#include <iostream>
using namespace std;

int main() 
{
    int a,b,c;
    bool isMultiple = false;

    cin >> a >> b >> c;

    for(int i = a; i <= b; i++)
    {
        if(i % c == 0)
        {
            isMultiple = true;
            break;
        }
    }

    cout << (isMultiple ? "NO" : "YES");

    return 0;
}