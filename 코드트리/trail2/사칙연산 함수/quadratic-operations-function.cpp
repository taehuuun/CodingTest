#include <iostream>

using namespace std;

int Plus(int a, int b)
{
    return a + b;
}

int Minus(int a, int b)
{
    return a - b;
}

int Multiple(int a, int b)
{
    return a * b;
}

int Mod(int a, int b)
{
    return a / b;
}

void PrintEquation(int a, char o, int b)
{
    cout << a << " " << o << " " << b << " = ";
}

void FourBasicOperations(int a, char o, int b)
{
    if(o == '+')
    {
        PrintEquation(a, o, b);
        cout << Plus(a,b);
    }
    else if(o == '-')
    {
        PrintEquation(a, o, b);
        cout << Minus(a, b);
    }
    else if(o == '*')
    {
        PrintEquation(a, o, b);
        cout << Multiple(a, b);
    }
    else if(o == '/')
    {
        PrintEquation(a, o, b);
        cout << Mod(a, b);
    }
    else
    {
        cout << "False";
    }
}

int main() 
{
    int a, b;
    char o;

    cin >> a >> o >> b;

    FourBasicOperations(a, o, b);

    return 0;
}