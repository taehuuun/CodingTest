#include <iostream>
using namespace std;

int main() {
    int N;
    cin >> N;

    // 1부터 N까지 증가하면서 별 출력
    for (int i = 1; i <= N; i++) {
        for (int j = 1; j <= i; j++) {
            cout << "*";
        }
        cout << endl;
        cout << endl; // 줄바꿈 한 번 더
    }

    // N-1부터 1까지 감소하면서 별 출력
    for (int i = N - 1; i >= 1; i--) {
        for (int j = 1; j <= i; j++) {
            cout << "*";
        }
        cout << endl;

        // 마지막 줄(별 1개) 뒤에는 줄바꿈을 추가로 넣지 않음
        if (i != 1) {
            cout << endl;
        }
    }

    return 0;
}