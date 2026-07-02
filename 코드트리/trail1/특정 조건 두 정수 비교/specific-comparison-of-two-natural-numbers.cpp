#include <iostream>
using namespace std;

int main() 
{
    int a, b;

    cin >> a >> b;

    cout << (a < b ? "1" : "0");
    cout << " ";
    cout << (a == b ? "1" : "0");

    return 0;
}