#include <iostream>
using namespace std;

int main() 
{
    int x, y;

    cin.get();
    cin.get();
    cin.get();
    cin.get();
    cin >> x;
    cin.get();
    cin >> y;

    int tmp = x;
    x = y;
    y = tmp;

    cout << "010-" << x << '-' << y;

    return 0;
}