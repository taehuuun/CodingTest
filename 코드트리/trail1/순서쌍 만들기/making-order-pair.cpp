#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    for(int y = n; y > 0; y--)
    {
        for(int x = n; x > 0; x--)
        {
            cout << "(" << y <<","<< x <<") ";
        }
        
        cout << endl;
    }

    return 0;
}