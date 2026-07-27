#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main() 
{
    string a, b;
    string aDit, bDit;

    cin >> a >> b;

    for(int i = 0; i < a.length(); i++)
    {
        if(!isdigit(a[i]))
        {
            continue;
        }

        aDit += a[i];
    }

    for(int i = 0; i < b.length(); i++)
    {
        if(!isdigit(b[i]))
        {
            continue;
        }

        bDit += b[i];
    }

    cout << stoi(aDit) + stoi(bDit);

    return 0;
}