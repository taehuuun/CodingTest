#include <iostream>

using namespace std;

int sum;

int main()
{
    for(int i = 0 ; i<5; i++)
    {
        int tmp;
        cin >> tmp;
        sum += tmp;
    }

    cout << sum;

    return 0;
}
