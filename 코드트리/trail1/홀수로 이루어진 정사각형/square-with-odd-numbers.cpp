#include <iostream>
using namespace std;

int main() 
{   
    int n;

    cin >> n;

    int num = 0;

    for(int i = 0; i < n; i++)
    {
        num = 11 + (i * 2);

        for(int j = 0; j < n; j++)
        {
            cout << num + (j * 2) << " ";
        }

        cout << endl;
    }

    return 0;
}