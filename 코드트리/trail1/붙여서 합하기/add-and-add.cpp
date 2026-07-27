#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string a, b, ab,ba;

    cin >> a >> b;

    ab = a + b;
    ba = b + a;

    cout << stoi(ab) + stoi(ba);

    return 0;
}