#include <iostream>
using namespace std;

int main() 
{
    int a;

    cin >> a;

    cout << (a % 3 == 0 ? "YES" : "NO") << endl;
    cout << (a % 5 == 0 ? "YES" : "NO") << endl;

    return 0;
}