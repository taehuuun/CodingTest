using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        
        // Board의 지뢰와 위험지역을 설정하는 함수
        SetBoard(board);
        
        // 설정이 끝난 Board의 안전지대를 카운트하는 함수
        answer = GetSafeAreaCount(board);
        
        return answer;
    }
    
    int GetSafeAreaCount(int[,] board)
    {
        // 리턴 시킬 변수
        int count = 0;

        // board의 size 만큼 반복 Ex) size = 5 일때, 25회 반복
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                // board[i,j] 가 0일때 카운트 증가
                if (board[i, j] == 0)
                    count++;
            }
        }

        // 결과를 리턴
        return count;
    }
    
    public void SetBoard(int[,] board)
    {
        // board의 세로 사이즈 할당
        int height = board.GetLength(0);
        
        // board의 가로 사이즈 할당
        int width = board.GetLength(1);

        // heigth, width 만큼 반복
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (board[y, x] == 1)
                {
                    // 지뢰의 위치로부터 상하좌우 대각선을 체크할 인덱스가 담긴 배열
                    int[,] coords = {
                        {y, x - 1},
                        {y, x + 1},
                        {y - 1, x},
                        {y + 1, x},
                        {y - 1, x - 1},
                        {y - 1, x + 1},
                        {y + 1, x - 1},
                        {y + 1, x + 1}
                    };
                    
                    // 인덱스 배열을 돌면서 board범위내이고, 지뢰 주변 인덱스가 일치하면 2로 설정
                    for (int i = 0; i < coords.GetLength(0); i++)
                    {
                        int coordY = coords[i,0];
                        int coordX = coords[i,1];

                        if (coordY >= 0 && coordY < height && coordX >= 0 && coordX < width && board[coordY, coordX] == 0)
                        {
                            board[coordY, coordX] = 2;
                        }
                    }
                }
            }
        }
    }
}