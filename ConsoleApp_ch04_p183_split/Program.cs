// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// p169
// 현재 시각을 기준으로 10초 동안 루프를 실행하고, 반복 횟수를 센다.
long start = DateTime.Now.Ticks;    // 현재 시각을 Ticks 단위로 저장
long count = 0;

// 현재 시각이 시작 시각 + 10초보다 크면 종료
while (start + (100000000) > DateTime.Now.Ticks)
{
    count++;    // 카운트 증가
}

Console.WriteLine(count);   // 카운트 출력

int length = 100;
for (int i = 0; i < count; i++)
{

}


// p183
// 문자열을 공백과 쉼표로 분할하고 비어있는 항목을 제외한 결과를 출력
string input = "Tomato           Potato 고구마, 사과";
string[] output = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

foreach (string line in output)
{
    Console.WriteLine(line);    // 잘린 문자열과 공백이 제거된 문자열 출력
}