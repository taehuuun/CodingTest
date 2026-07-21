#include <iostream>
#include <vector>
#include <algorithm>

int main()
{
    int n = 0, m = 0;
    std::cin >> n >> m;

    // 크기가 입력으로 정해지므로 vector. (고정 상수 크기가 아니면 vector가 기본)
    std::vector<std::vector<int>> grid(n, std::vector<int>(m));

    int counter = 1;
    const int lastDiag = (n - 1) + (m - 1);

    // d = r + c : 같은 반대각선 위의 칸은 r+c가 같다.
    for (int d = 0; d <= lastDiag; d++)
    {
        const int rStart = std::max(0, d - (m - 1));
        const int rEnd   = std::min(n - 1, d);

        // 한 대각선 안에서는 위(작은 r) → 아래(큰 r) 순으로 채운다.
        for (int r = rStart; r <= rEnd; r++)
        {
            const int c = d - r;
            grid[r][c] = counter++;
        }
    }

    // 행 단위 출력. 공백은 앞에 붙여 trailing space 방지.
    for (int r = 0; r < n; r++)
    {
        for (int c = 0; c < m; c++)
        {
            if (c > 0) std::cout << ' ';
            std::cout << grid[r][c];
        }
        std::cout << '\n';
    }

    return 0;
}