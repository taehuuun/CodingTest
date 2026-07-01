#include <iostream>
using namespace std;

int main() 
{
    int h, w;
    float b;

    cin >> h >> w;

    b = (10000 * w) / (h * h);

    cout << (int)b;
    if(b >= 25)
    {
        cout << endl << "Obesity";
    }

    return 0;
}