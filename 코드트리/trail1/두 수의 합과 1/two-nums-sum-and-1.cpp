#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int a, b, oneCnt = 0;
    string result = "";

    cin >> a >> b;

    result = to_string(a + b);

    for(int i = 0 ; i < result.length(); i++)
    {
        if(result[i] == '1')
        {
            oneCnt++;
        }
    }

    cout << oneCnt;

    return 0;
}