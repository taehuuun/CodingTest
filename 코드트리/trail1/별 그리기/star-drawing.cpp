#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    // 다이아몬드의 위쪽
    for(int i = 0 ; i < n - 1; i++)
    {
        for(int j = 0; j < n - i -1; j++)
        {
            cout << " ";
        }

        for(int j = 0; j < 2 * i +1; j++)
        {
            cout << "*";
        }
        cout << endl;
    }

    // 다이아몬드의 가운
    for(int i = 0 ; i < 2 * n - 1; i++)
    {
        cout << "*";
    }
    cout << endl;

    // 다이아몬드의 아래쪽
    for(int i = 0 ; i < n - 1; i++)
    {
        for(int j = 0; j < i+1; j++)
        {
            cout << " ";
        }

       for(int j = 0; j < 2 * (n - i) - 3; j++)
        {
            cout << "*";
        }

        cout << endl;
    }


    return 0;
}