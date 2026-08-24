#include <iostream>
#include <climits>

using namespace std;

int main()
{
    int max = INT_MIN, n, prev = -1, cnt = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int a;

        cin >> a;

        if(prev == a || i == 0)
        {
            cnt++;
            if(max < cnt)
            {
                max = cnt;
            }
        }
        else
        {

            cnt = 1;
        }

        prev = a;
    }

    cout << max;

    return 0;
}