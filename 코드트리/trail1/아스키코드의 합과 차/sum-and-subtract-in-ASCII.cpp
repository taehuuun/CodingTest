#include <iostream>
using namespace std;

int main() 
{
    char a, b;

    cin >> a >> b;

    int sum = (int)a + (int)b;
    int dif = ((int)a > (int)b) ? (int)a - (int)b : (int)b - (int)a;

    cout << sum << " " << dif;

    return 0;
}