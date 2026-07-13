#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;

    for (int r = 0; r < n; r++) {
        for (int c = 0; c < n; c++) {
            bool filled = (r == 0) || (c % 2 == 1 && r <= c);
            cout << (filled ? "* " : "  ");
        }
        cout << '\n';
    }
    return 0;
}