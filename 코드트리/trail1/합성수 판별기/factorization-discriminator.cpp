#include <iostream>
using namespace std;

int main() 
{
    int n;
    bool isFind = false;

    cin >> n;

    for(int i = 2; i <= (n - 1) ; i++)
    {
        if(n % i == 0)
        {
            isFind = true;
            break;
        }
    }

    cout << (isFind ? "C" : "N");

    return 0;
}