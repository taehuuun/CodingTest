#include <iostream>
using namespace std;

int main() 
{
    int a,b,c,d;

    cin >> a >> b >> c >> d;

    int startMinute = a * 60 + b;
    int endMinute = c * 60 + d;

    cout << endMinute - startMinute;

    return 0;
}