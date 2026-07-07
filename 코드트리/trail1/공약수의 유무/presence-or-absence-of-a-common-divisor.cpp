#include <iostream>
using namespace std;

int main() 
{
    int a, b;
    bool isFind = false;

    cin >> a >> b;

    for(int i = a; i <= b; i++)
    {
        if(1920 % i == 0 && 2880 % i == 0)
        {
            isFind = true;
            break;            
        }
    }

    cout << (isFind ? 1 : 0);

    return 0;
}