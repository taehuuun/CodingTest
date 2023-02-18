using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
        
        // db의 길이의 절반 만큼 반복
        for(int i = 0 ; i < db.Length /2 ; i++)
        {
            // id_pw[0](ID) 와 db[i,0](ID)를 비교하여 일치하는지 체크
            if(id_pw[0] == db[i,0])
            {
                // id_pw[1](PW) 와 db[i,1](PW)를 비교하여 일치하는지 체크
                // 일치하다면 login;
                // 일치하지 않으면 wrong pw
                if(id_pw[1] == db[i,1])
                {
                    answer = "login";
                }
                else
                {
                    answer = "wrong pw";                    
                }
            }
        }
        
        // 위 for문에서 해당 사항이 있다면 answer이 ""이 아닌점을 이용
        if(answer == "")
        {
            answer = "fail";
        }
        
        return answer;
    }
}