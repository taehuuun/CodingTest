#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input1, input2;

    cin >> input1 >> input2;

    cout << (input1 + input2 == input2 + input1 ? "true" : "false");

    return 0;
}