using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string[] players, string[] callings) 
    {
        // 간단한 구현 방법으로 2중 for문을 사용 할 경우, 최악의 조건 상황에서
        // 500억번 연산을 수행함으로 시간 초과가 발생
        // 딕셔너리를 활용하여 불필요한 반복 연산을 줄이는 방법 사용
        // 이 경우 최악의 조건 상황에서 110만번 연산 (약 99% 단축)
        
        // 플레이어 네임으로 O(1)의 접근을 해야함으로 딕셔너리를 생성
        Dictionary<string, int> rank = new Dictionary<string, int>();
        
        // 처음 players 배열 상태를 rank딕셔너리에 추가
        for (int i = 0; i < players.Length; i++)
        {
            rank.Add(players[i], i);
        }
        
        // callings길이 만큼 반복
        for (int i = 0; i < callings.Length; i++)
        {
            // 현재 callings요소의 인덱스(순위)를 구함
            int currentIdx = rank[callings[i]];
            
            // 현재 요소보다 앞에 있는 요소의 인덱스를 구함
            int frontIdx = currentIdx - 1;

            // 현재 선수보다 앞의 있는 선수의 이름을 구함
            string frontName = players[frontIdx];
            
            // 현재 선수의 이름을 구함
            string currentName = players[currentIdx];
            
            // 앞 선수와 현재 선수의 배열 순서를 바꿈 (스왑)
            string tmp = players[frontIdx];
            players[frontIdx] = players[currentIdx];
            players[currentIdx] = tmp;
            
            // 앞 선수의 순위를 증가
            rank[frontName]++;
            
            // 현 선수의 순위를 감소
            rank[currentName]--;
        }
        
        // players의 길이와 같은 answer배열 생성
        string[] answer = new string[players.Length];
        
        // rank의 키값들을 순환하며, 해당하는 순위에 선수 이름을 채워 넣음 
        foreach (var key in rank.Keys)
        {
            answer[rank[key]] = key;
        }
        
        return players;
    }
}