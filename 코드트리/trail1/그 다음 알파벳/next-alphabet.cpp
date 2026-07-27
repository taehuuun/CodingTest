#include <iostream>
using namespace std;

int main() 
{
    char a;

    cin >> a;

    cout << (a == 'z' ? 'a' : ((char)((int)a + 1)));

    return 0;
}