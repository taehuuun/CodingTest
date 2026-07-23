#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int eeCnt = 0, ebCnt = 0;

    cin >> input;

    for(int i = 0; i < input.length()-1; i++)
    {
        if(input.substr(i,2) == "ee")
        {
            eeCnt++;
        }

        if(input.substr(i,2) == "eb")
        {
            ebCnt++;
        }
    }

    cout << eeCnt << " " << ebCnt;

    return 0;
}