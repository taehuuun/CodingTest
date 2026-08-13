#include <iostream>
#include <string>

using namespace std;

class Disarm
{
    public:
        string code;
        char color;
        int second;

    public:
        Disarm()
        {
            this->code = "";
            this->color = ' ';
            this->second = 0;
        }
};

int main() 
{
    Disarm disarm;

    cin >> disarm.code >> disarm.color >> disarm.second;

    cout << "code : " << disarm.code << endl;
    cout << "color : " << disarm.color << endl;
    cout << "second : " << disarm.second;

    return 0;
}