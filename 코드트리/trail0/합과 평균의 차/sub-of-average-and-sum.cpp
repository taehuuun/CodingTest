#include <iostream>
using namespace std;

int main() {
    int a,b,c = 0;

    cin >> a >> b >> c;

    int sum = a+b+c;
    int avg = (a+b+c) / 3;

    cout << sum << endl;
    cout << avg << endl;
    cout << sum - avg;

    return 0;
}