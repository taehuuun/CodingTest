#include <iostream>
using namespace std;

void PrintUp(int n)
{
    if(n == 0)
    {
        return;
    }

    PrintUp(n-1);
    cout << n << " ";
}

void PrintDown(int n)
{
    if(n == 0)
    {
        return;
    }

    cout << n << " ";
    PrintDown(n-1);
}

int main() 
{
    int n;

    cin >> n;

    PrintUp(n);
    cout << endl;
    PrintDown(n);

    return 0;
}