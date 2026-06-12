#include <iostream>
using namespace std;

int main() 
{
    int weight = 13;
    float moonGrav = 0.165;

    cout << fixed;
    cout.precision(6);

    cout << weight << " * " << moonGrav << " = " << weight * moonGrav;

    return 0;
}