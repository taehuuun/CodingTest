#include <iostream>
using namespace std;

int main() 
{
    char a;
    float b,c;

    cin >> a >> b >> c;

    cout << fixed;
    cout.precision(2);

    cout << a << endl;
    cout << b << endl;
    cout << c;

    return 0;
}