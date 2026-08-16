#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

class Student
{
    public:
        string name;
        int kor;
        int eng;
        int math;
};

bool Compare(const Student& a, const Student& b)
{
    return a.kor+a.eng+a.math < b.kor + b.eng + b.math;
}

int main() 
{
    const int MAX_SIZE = 10;
    Student students[MAX_SIZE];

    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> students[i].name >> students[i].kor >> students[i].eng >> students[i].math;
    }

    sort(students, students + n, Compare);

    for(int i = 0; i < n; i++)
    {
        cout << students[i].name << ' ' << students[i].kor << ' ' << students[i].eng << ' ' << students[i].math << endl;
    }

    return 0;
}