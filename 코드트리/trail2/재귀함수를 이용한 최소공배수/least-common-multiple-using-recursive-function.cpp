#include <iostream>

int gcd(int a, int b)
{
    if (b == 0) return a;      // 종료 조건: 나머지가 0이면 a가 최대공약수
    return gcd(b, a % b);      // gcd(a,b) = gcd(b, a%b)
}

int lcm(int a, int b)
{
    return a / gcd(a, b) * b;  // a*b/gcd 대신 (a/gcd)*b — 중간 오버플로 방지
}

int main()
{
    int n = 0;
    std::cin >> n;

    int result = 0;
    for (int i = 0; i < n; i++)
    {
        int x;
        std::cin >> x;
        result = (i == 0) ? x : lcm(result, x);   // 첫 원소는 그대로, 이후 누적
    }

    std::cout << result;
    return 0;
}