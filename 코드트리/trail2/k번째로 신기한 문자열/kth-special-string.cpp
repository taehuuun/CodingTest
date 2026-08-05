#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

const int MAX_SIZE = 100;

int main()
{
    int n, k, findIdx = 0;
    string target, strList[MAX_SIZE], findList[MAX_SIZE];

    cin >> n >> k >> target;

    for(int i = 0; i < n; i++)
    {
        cin >> strList[i];
    }

    for(int i = 0; i < n; i++)
    {
        if(strList[i][0] != target[0])
        {
            continue;
        }

        bool isSame = true;

        for(int j = 1; j < target.length(); j++)
        {
            if(strList[i][j] != target[j])
            {
                isSame = false;
                break;
            }
        }

        if(isSame)
        {
            findList[findIdx] = strList[i];
            findIdx++;
        }
    }

    sort(findList, findList + findIdx);

    cout << findList[k-1];

    return 0;
}