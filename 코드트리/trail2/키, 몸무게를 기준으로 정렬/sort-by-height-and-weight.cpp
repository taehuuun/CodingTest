#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

class Person
{
    public:
        string name;
        int height;
        int weight;
};

bool Compare(const Person& a, const Person& b)
{
    if(a.height == b.height)
    {
        return a.weight > b.weight;
    }

    return a.height < b.height;
}

int main() 
{
    const int MAX_SIZE = 10;

    Person persons[MAX_SIZE];
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> persons[i].name >> persons[i].height >> persons[i].weight;
    }

    sort(persons, persons + n, Compare);

    for(int i = 0; i < n; i++)
    {
        cout << persons[i].name << ' ' << persons[i].height << ' ' << persons[i].weight << '\n';
    }

    return 0;
}