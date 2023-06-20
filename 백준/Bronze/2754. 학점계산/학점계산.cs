// 입력에 해당하는 값을 출력하기 위한 Dictionary 생성
Dictionary<string,string> dictionary = new Dictionary<string, string>();

// dictionary 키와 값을 추가
dictionary.Add("A+","4.3");
dictionary.Add("A0","4.0");
dictionary.Add("A-","3.7");
dictionary.Add("B+","3.3");
dictionary.Add("B0","3.0");
dictionary.Add("B-","2.7");
dictionary.Add("C+","2.3");
dictionary.Add("C0","2.0");
dictionary.Add("C-","1.7");
dictionary.Add("D+","1.3");
dictionary.Add("D0","1.0");
dictionary.Add("D-","0.7");
dictionary.Add("F","0.0");

// 문자열로 입력을 받음
string input = Console.ReadLine();

// dictionary에 input에 해당하는 값을 출력
Console.WriteLine(dictionary[input]);