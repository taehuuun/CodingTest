#include <iostream>
#include <string>

using namespace std;

int main() 
{
    char a[20];
    char b[20];

    cin >> a >> b;

    int aLen = 0;
    int bLen = 0;

    for(int i = 0; i < sizeof(a); i++)
    {
        if(a[i] == '\0')
        {
            break;
        }

        aLen++;
    }

    for(int i = 0; i < sizeof(b); i++)
    {
        if(b[i] == '\0')
        {
            break;
        }

        bLen++;
    }

    if(aLen == bLen)
    {
        cout << "same";
    }
    else if(aLen > bLen)
    {
        cout << a << " " << aLen;
    }
    else
    {
        cout << b << " " << bLen;
    }

    return 0;
}