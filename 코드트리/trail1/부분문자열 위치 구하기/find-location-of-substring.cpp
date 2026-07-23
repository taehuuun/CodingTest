#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input1, input2;

    cin >> input1 >> input2;

    if(input1.find(input2) != string::npos)
    {
        cout << input1.find(input2);
    }
    else
    {
        cout << -1;
    }

    return 0;
}