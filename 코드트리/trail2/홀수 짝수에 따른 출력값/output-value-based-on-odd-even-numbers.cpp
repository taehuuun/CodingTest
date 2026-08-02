#include <iostream>

using namespace std;

int Func(int n)
{
    if(n == 1)
        return 1;
    if(n == 2)
        return 2;

    // n과 홀짝이 같은 수만을 재귀함수로 호출합니다.
    return Func(n - 2) + n;
}

int main() 
{
    int n;

    cin >> n;

    cout << Func(n);

    return 0;
}