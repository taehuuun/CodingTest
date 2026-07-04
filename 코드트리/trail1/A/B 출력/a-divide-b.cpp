#include <iostream>
using namespace std;

int main() {
    int A, B;
    cin >> A >> B;

    // 정수 부분 출력
    cout << A / B << ".";

    // 나머지 계산
    int remainder = A % B;

    // 소수점 아래 20자리를 한 자리씩 계산하여 출력
    for (int i = 0; i < 20; i++) {
        remainder = remainder * 10;
        int digit = remainder / B;
        cout << digit;
        remainder = remainder % B;
    }

    cout << endl;

    return 0;
}