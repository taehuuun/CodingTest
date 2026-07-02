#include <iostream>
using namespace std;

int main() 
{
    float a, b;

    cin >> a >> b;

    if(a >= 1.0f && b >= 1.0f)
    {
        cout << "High";
    }
    else if(a >= 0.5f && b >= 0.5f)
    {
        cout << "Middle";
    }
    else
    {
        cout << "Low";
    }

    return 0;
}