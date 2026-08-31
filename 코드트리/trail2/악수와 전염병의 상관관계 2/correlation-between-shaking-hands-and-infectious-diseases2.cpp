#include <iostream>
#include <algorithm>

#define MAX_N 100
#define MAX_T 250

using namespace std;

int n, k, p, t;
int shake_num[MAX_N + 1];
bool infected[MAX_N + 1];

// 악수의 정보를 나타내는 클래스 선언
class Shake{
    public:
        int time;
        int person1;
        int person2;
        Shake(int time, int person1, int person2) {
            this->time = time;
            this->person1 = person1;
            this->person2 = person2;
        }
        Shake(){}
};

// Custom Comparator
bool Cmp(const Shake &a, const Shake &b) {
    // 시간을 기준으로 오름차순으로 정렬합니다.
    return a.time < b.time;
}

int main() {
    // 입력
    cin >> n >> k >> p >> t;
    infected[p] = true;
    
    Shake shakes[MAX_T];
    
    for(int i = 0; i < t; i++) {
        int time, person1, person2;
        cin >> time >> person1 >> person2;
        // Shake 객체를 생성해 넣어줍니다.
        shakes[i] = Shake(time, person1, person2);
    }
    
    // custom comparator를 활용한 정렬
    sort(shakes, shakes + t, Cmp);
    
    // 각 악수 횟수를 세서,
    // K번 초과로 악수를 했을 시 전염시키지 않습니다.
    for(int i = 0; i < t; i++) {
        int target1 = shakes[i].person1;
        int target2 = shakes[i].person2;
        
        // 감염되어 있을 경우 악수 횟수를 증가시킵니다.
        if(infected[target1])
            shake_num[target1]++;
        if(infected[target2])
            shake_num[target2]++;
        
        // target1이 감염되어 있고 아직 K번 이하로 악수했다면 target2를 전염시킵니다.
        if(shake_num[target1] <= k && infected[target1])
            infected[target2] = true;
        
        // target2가 감염되어 있고 아직 K번 이하로 악수했다면 target1을 전염시킵니다.
        if(shake_num[target2] <= k && infected[target2])
            infected[target1] = true;
    }
    
    for(int i = 1; i <= n; i++) {
        if(infected[i])
            cout << 1;
        else
            cout << 0;
    }
    cout << '\n';
    
    return 0;
}
