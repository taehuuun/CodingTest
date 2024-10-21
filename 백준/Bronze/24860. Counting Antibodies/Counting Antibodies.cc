#include <iostream>

using namespace std;

int main()
{
    long long k1, k2;
    long long r1, r2;
    long long h1, h2, h3;
    
    unsigned long long result;
    
    cin >> k1 >> k2;
    cin >> r1 >> r2;
    cin >> h1 >> h2 >> h3;
    
    result = (k1 * k2 + r1 * r2) * (h1 * h2 * h3);
    
    cout << result;
    
    return 0;
}