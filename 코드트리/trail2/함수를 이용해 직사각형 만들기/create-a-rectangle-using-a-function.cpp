#include <iostream>
using namespace std;

void PrintOne(int n, int m)
{
    for(int y = 0; y < n; y++)
    {
        for(int x = 0; x < m; x++)
        {
            cout << "1";
        }

        cout << endl;
    }
}

int main() 
{
    int n,m;

    cin >> n >> m;

    PrintOne(n, m);
    return 0;
}