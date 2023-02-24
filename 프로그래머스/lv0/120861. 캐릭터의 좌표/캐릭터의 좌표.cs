using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) 
    {
        // 반환할 결과 값을 저장하는 배열
        int[] answer = new int[2];

        // 보드의 너비
        int width = board[0];

        // 보드의 높이
        int height = board[1];

        // 보드의 중심을 나타내는 x 좌표
        int centerX = (width - 1) / 2; 

        // 보드의 중심을 나타내는 y 좌표
        int centerY = (height - 1) / 2;

        // 현재 위치를 나타내는 x 좌표
        int curX = centerX;

        // 현재 위치를 나타내는 y 좌표
        int curY = centerY;

        // 입력된 키 목록을 반복하여 이동
        foreach (var key in keyinput)
        {
            switch (key)
            {
                // 왼쪽 방향키인 경우
                case "left": 
                    // 보드를 벗어나지 않도록 조건 체크
                    // 만족하면 x좌표를 왼쪽으로 이동
                    if (curX > 0) 
                        curX--; 
                    break;
                    
                // 오른쪽 방향키인 경우
                case "right": 
                    // 보드를 벗어나지 않도록 조건 체크
                    // 만족하면 x좌표를 오른쪽으로 이동
                    if (curX < width-1) 
                        curX++; 
                    break;
                    
                // 위쪽 방향키인 경우
                case "up": 
                    // 보드를 벗어나지 않도록 조건 체크
                    // 만족하면 y좌표를 위쪽으로 이동
                    if (curY > 0) 
                        curY--; 
                    break;
                    
                // 아래쪽 방향키인 경우
                case "down": 
                    // 보드를 벗어나지 않도록 조건 체크
                    // 만족하면 y좌표를 아래쪽으로 이동
                    if (curY < height - 1) 
                        curY++;
                    break;
            }
        }

        // 결과 값을 반환할 배열에 저장
        answer[0] = curX - centerX; // 보정 값을 뺀 x좌표 저장
        answer[1] = centerY - curY; // 보정 값을 뺀 y좌표 저장

        // 결과 값을 반환
        return answer;
    }
}