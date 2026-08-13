#include <iostream>
#include <string>

using namespace std;

class Product
{
    public:
        string name;
        int code;
    
    public:
        Product(string name = "codetree", int code = 50) : name(name), code(code)
        {

        }
};

int main()
{
    Product product1, product2;

    cin >> product2.name >> product2.code;

    cout << "product " << product1.code << " is " << product1.name << endl;
    cout << "product " << product2.code << " is " << product2.name;

    return 0;
}