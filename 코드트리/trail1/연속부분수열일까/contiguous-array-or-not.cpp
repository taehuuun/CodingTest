#include <array>
#include <iostream>

int main()
{
    constexpr int maxSize = 100;
    std::array<int, maxSize> aArr, bArr;

    int aLen = 0, bLen = 0;
    std::cin >> aLen >> bLen;

    for (int i = 0; i < aLen; i++)
    {
        std::cin >> aArr[i];
    }

    for (int i = 0; i < bLen; i++)
    {
        std::cin >> bArr[i];
    }

    bool found = false;

    for (int start = 0; start + bLen <= aLen; start++)
    {
        bool matched = true;

        for (int j = 0; j < bLen; j++)
        {
            if (aArr[start + j] != bArr[j])
            {
                matched = false;
                break;
            }
        }

        if (matched)
        {
            found = true;
            break;
        }
    }

    std::cout << (found ? "Yes" : "No");

    return 0;
}