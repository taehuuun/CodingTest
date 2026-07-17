#include <iostream>
using namespace std;

int main() 
{
    const int maxSize = 100;
    int aLen, bLen, aArr[maxSize], bArr[maxSize], findIdx = 0;

    cin >> aLen >> bLen;

    for(int i = 0; i < aLen; i++)
    {
        cin >> aArr[i];
    }

    for(int i = 0 ; i < bLen; i++)
    {
        cin >> bArr[i];
    }

    for(int i = 0 ; i < aLen; i++)
    {
        if(findIdx == bLen)
        {
            break;
        }

        if(aArr[i] != bArr[findIdx])
        {
            findIdx = 0;
            continue;
        }

        findIdx++;
    }

    if(findIdx == bLen)
    {
        cout << "Yes";
    }
    else
    {
        cout << "No";
    }

    return 0;
}