#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<string> vec = {"c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="};

int main() {
    
    // 입력받은 문자열을 find함수를 이용해서
	// vec 벡터속 문자열과 일치하면 해당 문자 갯수만큼
	// @로 바꾼다. 최종적으로 S의 길이가 알파벳의 숫자 
    
    int index = 0;
    string S;
    cin>>S;
    for(int i=0; i<vec.size(); i++){
        index = S.find(vec[i]);
        for(; index != string::npos; index = S.find(vec[i]))
            S.replace(index, vec[i].length(), "@");
    }
    cout<<S.length();
}