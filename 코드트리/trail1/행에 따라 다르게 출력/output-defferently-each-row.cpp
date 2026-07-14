#include <iostream>
using namespace std;

int main() 
{
    int n, num = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        if(i % 2 == 0)
        {
            for(int j = 0 ; j < n; j++)
            {
                num++;

                cout << num << " ";
            }
        }
        else
        {
            for(int j = 0 ; j < n; j++)
            {
                num += 2;

                cout << num << " ";
            }
        }

        cout << endl;
    }

    return 0;
}