#include <iostream>
using namespace std;

void Print(int n)
{
    for(int i = 0; i < n; i++)
    {
        cout << "* ";
    }

    cout << endl;
}

void PrintStar(int n)
{
    if(n == 0)
    {
        return;
    }

    Print(n);
    PrintStar(n-1);
    Print(n);
}

int main() 
{
    int n;

    cin >> n;

    PrintStar(n);

    return 0;
}