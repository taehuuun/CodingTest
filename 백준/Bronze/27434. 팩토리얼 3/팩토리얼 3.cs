using System.Numerics;

// 입력: N (0 <= N <= 100000)
int n = int.Parse(Console.ReadLine()!.Trim());

// 0! = 1, 1! = 1
if (n < 2)
{
    Console.WriteLine(1);
    return;
}

// 2부터 N까지의 곱을 분할정복으로 계산
BigInteger ans = ProductRange(2, n);
Console.WriteLine(ans.ToString());

BigInteger ProductRange(int l, int r)
{
    // 구간이 비면 곱의 항등원 1
    if (l > r) return BigInteger.One;

    // 원소 1개면 그대로 반환
    if (l == r) return new BigInteger(l);

    // 원소 2개면 바로 곱 (재귀 호출 줄여서 오버헤드 감소)
    if (r - l == 1)
        return new BigInteger(l) * r;

    int mid = (l + r) >> 1;

    // 왼쪽 구간 곱
    BigInteger left = ProductRange(l, mid);
    // 오른쪽 구간 곱
    BigInteger right = ProductRange(mid + 1, r);

    // 비슷한 크기의 수끼리 곱하도록 만들어 BigInteger 연산이 유리해짐
    return left * right;
}