#include <iostream>
using namespace std;

int main() {
    float a,b = 0;
    float avg = 0;

    cin >> a >> b;

    avg = (a+b) / 2;

    cout << (int)a + b;
    cout << fixed;
    cout.precision(1);
    cout<< " " << avg;

    return 0;
}