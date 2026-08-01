#include <iostream>
using namespace std;

void PrintHelloWorld(int n)
{
    if(n == 0)
    {
        return;
    }

    PrintHelloWorld(n-1);

    cout << "HelloWorld" << endl;
}

int main() 
{
    int n;

    cin >> n;

    PrintHelloWorld(n);

    return 0;
}