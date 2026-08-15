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

bool Compare(const Student& student1, const Student& student2)
{
    if(student1.kor == student2.kor)
    {
        if(student1.eng == student2.eng)
        {
            return student1.math > student2.math;
        }
        else
        {
            return student1.eng > student2.eng;
        }
    }
    else
    {
        return student1.kor > student2.kor;
    }
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