using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] id_list, string[] report, int k) 
    {
        List<int> answer = new List<int>();
        
        // 각각 신고 받은 횟수를 기록
        Dictionary<string, int> reportCountDic = new Dictionary<string,int>();
        
        // 결과 메일을 몇개를 받는지 기록
        Dictionary<string, int> resultMailCountDic = new Dictionary<string,int>();
        
        // 누가 신고를 했는지 기록
        Dictionary<string, List<string>> reporterDic = new Dictionary<string,List<string>>();
        
        // id_list 길이 만큼 반복 하며, 각각 딕셔너리를 세팅
        for(int i = 0 ; i < id_list.Length; i++)
        {
            reportCountDic.Add(id_list[i],0);
            resultMailCountDic.Add(id_list[i],0);
            reporterDic.Add(id_list[i], new List<string>());
        }
        
        // report 길이만큼 반복
        for(int i = 0 ; i < report.Length; i++)
        {
            // report를 공백을 기준으로 분리
            string[] reportId = report[i].Split(" ");
            
            // reportId[1]를 신고한 사람 reportId[0]이 포함되어있는지 체크
            if(!reporterDic[reportId[1]].Contains(reportId[0]))
            {
                // reportId[1]를 키로 신고 횟수를 증가
                reportCountDic[reportId[1]]++;
                
                // reportId[1]를 신고한 사람 reportId[0]를 추가
                reporterDic[reportId[1]].Add(reportId[0]);
            }
        }
        
        // reporterDic의 키 값들을 이용
        foreach(var key in reporterDic.Keys)
        {
            // reporterDic의 Key를 신고한 사람의 Count만큼 반복
            for(int i = 0 ; i < reporterDic[key].Count; i++)
            {
                // 신고 한 횟수가 k보다 크거나 같을 때
                if(reportCountDic[key] >= k)
                {
                    // reporterDic[key][i]에게 결과 메일을 보냄(카운트 증가)
                    resultMailCountDic[reporterDic[key][i]]++;
                }
            }
        }
        
        // answer 리스트에 값들을 추가
        foreach(var key in resultMailCountDic.Keys)
        {
            answer.Add(resultMailCountDic[key]);
        }
        
        // 배열의 형태로 변환
        return answer.ToArray();
    }
}