#include <iostream>
using namespace std;

int main() 
{
    int a;

    cin >> a;

    cout << a;
    if(a < 0)
    {
        cout << endl;
        cout << "minus";
    }

    return 0;
}