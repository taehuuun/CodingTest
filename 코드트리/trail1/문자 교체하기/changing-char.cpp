#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input1, input2;

    cin >> input1 >> input2;

    input2[0] = input1[0];
    input2[1] = input1[1];

    cout << input2;

    return 0;
}