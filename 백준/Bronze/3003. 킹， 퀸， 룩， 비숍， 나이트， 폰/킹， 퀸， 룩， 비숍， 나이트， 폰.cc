#include <iostream>

using namespace std;

int piece[6] = {1,1,2,2,2,8};
int input[6];

int main()
{
    for(int i = 0; i<6; i++)
    {
        cin >> input[i];
        cout <<piece[i] - input[i] << " ";
    }
    return 0;
}
