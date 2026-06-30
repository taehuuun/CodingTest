#include <iostream>
using namespace std;

int main() 
{
    int width, length;

    cin >> width >> length;

    width += 8;
    length *= 3;

    cout << width << endl;
    cout << length << endl;
    cout << width * length;

    return 0;
}