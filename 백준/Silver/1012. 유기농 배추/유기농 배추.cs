// 테스트 케이스 개수를 입력 받음
int t = int.Parse(Console.ReadLine());

// 가로 세로 배추 개수 정보를 입력 받을 문자열
string inputInfo = "";

// inputInfo의 데이터를 분리할 문자열 배열
string[] splitInput;

// 맵의 너비
int widthM = 0;

// 맵의 높이
int heightN = 0;

// 심을 배추의 개수
int cabbageCntK = 0;
    
int[,] map;
bool[,] visited;
int[] dirX = { 0, 0, -1, 1};
int[] dirY = { -1, 1, 0, 0};

int wormCnt;

// 입력된 테스트 케이스 개수 만큼 반복
for (int T = 0; T < t; T++)
{
    // 지렁이 마리 수 초기화
    wormCnt = 0;
    // 가로 세로 배추 개수를 string을 입력
    inputInfo = Console.ReadLine();
    
    // 입력된 string을 공백을 기준으로 분리
    splitInput = inputInfo.Split(' ');
    
    // splitInput의 0번쨰 값을 widthM에 대입
    widthM = int.Parse(splitInput[0]);
    
    // splitInput의 1번쨰 값을 heightN에 대입
    heightN = int.Parse(splitInput[1]);
    
    // splitInput의 2번쨰 값을 cabbageCntK에 대입
    cabbageCntK = int.Parse(splitInput[2]);
    
    // 입력 받은 가로 세로 데이터초 map과 visited 배열을 생성
    map = new int[heightN,widthM];
    visited = new bool[heightN,widthM];
    
    // 배추를 map에 배치
    for (int i = 0; i < cabbageCntK; i++)
    {
        // 배치할 배추의 좌표를 문자열로 입력 받음
        string inputCoord = Console.ReadLine();
        
        // 입력 받은 문자열을 공백으로 분리
        string[] splitCoord = inputCoord.Split(' ');

        // 분리된 문자열을 각 x, y에 대입
        int x = int.Parse(splitCoord[0]);
        int y = int.Parse(splitCoord[1]);
        
        // 해당하는 좌표를 1로 변경 (배추 배치)
        map[y, x] = 1;
    }

    for (int y = 0; y < heightN; y++)
    {
        for (int x = 0; x < widthM; x++)
        {
            if (map[y, x] == 1 && !visited[y,x])
            {
                DFS(x,y);
                wormCnt++;
            }
        }
    }
    
    Console.WriteLine(wormCnt);
}

void DFS(int x, int y)
{
    if(visited[y,x])
        return;
    
    visited[y,x] = true;

    for (int i = 0; i < 4; i++)
    {
        int nextX = x + dirX[i];
        int nextY = y + dirY[i];

        if (nextX >= 0 && nextX < widthM &&
            nextY >= 0 && nextY < heightN &&
            map[nextY,nextX] == 1 && !visited[nextY,nextX])
        {
            DFS(nextX,nextY);
        }
    }
}