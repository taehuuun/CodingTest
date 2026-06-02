#include <iostream>
using namespace std;

int main() 
{
    int n = 0;

    cin >> n;

    if(n >= 80)
    {
        cout << "pass" << endl;
    }
    else
    {

        cout << 80 - n << " more score";
    }

    return 0;
}