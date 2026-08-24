#include <iostream>
#include <climits>

using namespace std;

int main()
{
    int n, positiveMax = INT_MIN, nagativeMax = INT_MIN, positiveCnt = 0, nagativeCnt = 0;
    bool prevPositive = false;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        int input;

        cin >> input;

        if((prevPositive && input > 0) || (!prevPositive && input < 0) || i == 0)
        {
            if(input > 0)
            {
                prevPositive = true;
                positiveCnt++;

                if(positiveMax < positiveCnt)
                {
                    positiveMax = positiveCnt;
                }
            }
            else
            {
                prevPositive = false;
                nagativeCnt++;

                if(nagativeMax < nagativeCnt)
                {
                    nagativeMax = nagativeCnt;
                }
            }
        }
        else
        {
            if(prevPositive)
            {
                nagativeCnt = 1;
                prevPositive = false;
            }
            else
            {
                positiveCnt = 1;
                prevPositive = true;
            }
        }
    }

    cout << ((positiveMax > nagativeMax ? positiveMax : nagativeMax));

    return 0;
}