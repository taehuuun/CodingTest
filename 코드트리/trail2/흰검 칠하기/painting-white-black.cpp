#include <iostream>
using namespace std;

class Tile
{
    public:
        char status;
        int changeWhiteCnt;
        int changeBlackCnt;
    public:
        Tile()
        {
            status = 'E';
            changeWhiteCnt = 0;
            changeBlackCnt = 0;
        }

        void ChangeBlack()
        {
            if(status == 'G')
            {
                return;
            }

            status = 'B';
            changeBlackCnt++;

            if(IsGray())
            {
                status = 'G';
            }
        }

        void ChangeWhite()
        {
            if(status == 'G')
            {
                return;
            }

            status = 'W';
            changeWhiteCnt++;

            if(IsGray())
            {
                status = 'G';
            }
        }

        bool IsGray()
        {
            return changeBlackCnt >= 2 && changeWhiteCnt >= 2;
        }
};

int main() 
{
    const int OFF_SET = 100'000;
    Tile tiles[2 * OFF_SET + 1] = {};
    int n, current = OFF_SET;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int x;
        char dir;

        cin >> x >> dir;

        if(dir == 'L')
        {
            for(int i = current; i > current - x; i--)
            {
                tiles[i].ChangeWhite();
            }

            current -= x - 1;
        }
        else
        {
            for(int i = current; i < current +x; i++)
            {
                tiles[i].ChangeBlack();
            }

            current += x - 1;
        }
    }

    int whiteCnt = 0, blackCnt = 0, grayCnt = 0;

    for(int i = 0; i < 2 * OFF_SET +1; i++)
    {
        if(tiles[i].status == 'E')
        {
            continue;
        }

        if(tiles[i].status == 'W')
        {
            whiteCnt++;
        }
        else if(tiles[i].status == 'B')
        {
            blackCnt++;
        }
        else if(tiles[i].status == 'G')
        {
            grayCnt++;
        }
    }

    cout << whiteCnt << ' ' << blackCnt << ' ' << grayCnt;

    return 0;
}