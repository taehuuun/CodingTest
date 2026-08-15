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

bool Comp(const Person& person1, const Person& person2)
{
    return person1.height < person2.height;
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

    sort(persons, persons + n, Comp);

    for(int i = 0 ; i < n; i++)
    {
        cout << persons[i].name << ' ' << persons[i].height << ' ' << persons[i].weight << endl;
    }

    return 0;
}