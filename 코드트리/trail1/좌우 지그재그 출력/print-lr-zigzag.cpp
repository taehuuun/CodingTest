#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;

    for (int i = 0; i < n; i++) {
        int start = n * i + 1;      // 이 행의 첫 수
        int end   = n * i + n;      // 이 행의 마지막 수
        if (i % 2 == 0)
            for (int j = start; j <= end; j++) cout << j << " ";
        else
            for (int j = end; j >= start; j--) cout << j << " ";
        cout << '\n';
    }
    return 0;
}