using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string today, string[] terms, string[] privacies) 
    {
        // 약관 종류와, 약관 값(몇 달) 들을 저장하기 위한 딕셔너리
        Dictionary<string, int> termsDic = new Dictionary<string, int>();
        
        // 만료된 이용 약관을 저장하기 위한 리스트
        List<int> removeList = new List<int>();
        
        // 이용 약관과 이용 약관 유효기간을 저장하기 위한 리스트
        List<string> privTerms = new List<string>();
        List<DateTime> privDate = new List<DateTime>();

        // 입력받은 오늘 날짜를 DateTime 형태로 저장
        DateTime toDayDate = StringToDate(today);

        // 약관들을 딕셔너리에 저장
        for (int i = 0; i < terms.Length; i++)
        {
            string[] splitTerms = terms[i].Split(' ');
            int termsValue = int.Parse(splitTerms[1]);
            termsDic.Add(splitTerms[0], termsValue);
        }

        // 이용 약관의 날짜와 약관 종류를 리스트에 저장
        for (int i = 0; i < privacies.Length; i++)
        {
            string[] splitPriva = privacies[i].Split(' ');
            privDate.Add(StringToDate(splitPriva[0]));
            privTerms.Add(splitPriva[1]);
        }

        // 유효기간이 만료된 이용 약관을 removeList에 추가
        for (int i = 0; i < privDate.Count; i++)
        {
            // 유효기간을 계산
            DateTime limitDate = privDate[i].AddMonths(termsDic[privTerms[i]]);
            TimeSpan dateDif = limitDate - toDayDate.AddDays(1);

            // 유효기간이 오늘 날짜를 지나갔다면, removeList에 추가
            if (dateDif.TotalDays < 0)
            {
                removeList.Add(i+1);
            }
        }

        return removeList.ToArray();
    }

    // yyyy.mm.dd 형식의 문자열을 DateTime 형태로 변환하는 함수
    public DateTime StringToDate(string date)
    {
        string[] splitDate = date.Split('.');
        int year = int.Parse(splitDate[0]);
        int month = int.Parse(splitDate[1]);
        int day = int.Parse(splitDate[2]);
        DateTime newDate = new DateTime(year, month, day);

        return newDate;
    }

}