#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    input.erase(1,1);
    input.erase(input.length()-2, 1);

    cout << input;

    return 0;
}