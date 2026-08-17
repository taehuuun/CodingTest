#include <iostream>
#include <algorithm>

using namespace std;

class Element
{
    public:
        int originIdx;
        int afterIdx;
        int value;
};

bool CompareOrigin(const Element& a, const Element& b)
{
    return a.originIdx < b.originIdx;
}

bool CompareValue(const Element& a, const Element& b)
{
    if(a.value == b.value)
    {
        return a.originIdx < b.originIdx;
    }

    return a.value < b.value;  
}

int main()
{
    const int MAX_SIZE = 1000;
    Element elements[MAX_SIZE];
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> elements[i].value;
        elements[i].originIdx = i+1;
    }

    sort(elements, elements + n, CompareValue);

    for(int i = 0; i < n; i++)
    {
        elements[i].afterIdx = i+1;
    }

    sort(elements, elements + n, CompareOrigin);

    for(int i = 0; i < n; i++)
    {
        cout << elements[i].afterIdx << ' ';
    }

    return 0;
}