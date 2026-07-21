#include <iostream>

int main()
{
    int n = 0;
    std::cin >> n;

    int grid[10][10];   // N <= 10. 쓰기가 먼저라 초기화 불필요.

    int counter = 1;
    bool goingUp = true;            // 첫 열은 위로

    // 오른쪽 열부터 왼쪽으로
    for (int c = n - 1; c >= 0; c--)
    {
        if (goingUp)
        {
            for (int r = n - 1; r >= 0; r--)   // 아래 → 위
            {
                grid[r][c] = counter++;
            }
        }
        else
        {
            for (int r = 0; r < n; r++)         // 위 → 아래
            {
                grid[r][c] = counter++;
            }
        }

        goingUp = !goingUp;         // 다음 열은 방향 반대
    }

    // 행 단위 출력. 공백은 앞에 붙여 끝 공백 방지.
    for (int r = 0; r < n; r++)
    {
        for (int c = 0; c < n; c++)
        {
            if (c > 0) std::cout << ' ';
            std::cout << grid[r][c];
        }
        std::cout << '\n';
    }

    return 0;
}