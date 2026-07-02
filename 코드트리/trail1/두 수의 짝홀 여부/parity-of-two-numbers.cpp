#include <iostream>
using namespace std;

void IsEven(int);

int main() 
{
    int a, b;

    cin >> a >> b;

    IsEven(a);
    IsEven(b);

    return 0;
}

void IsEven(int num)
{
    if(num % 2 == 0)
    {
        cout << "even" << endl;
    }
    else
    {
        cout << "odd" << endl;
    }
}