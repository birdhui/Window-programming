// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Main(string[] args)
{
    Console.WriteLine("학년을 입력하세요: ");
    int level = int.Parse(Console.ReadLine());

    switch (level)
    {
        case 1:
            Console.WriteLine("수강해야 하는 전공 학점: 12학점");
            break;
        case 2:
            Console.WriteLine("수강해야 하는 전공 학점: 18학점");
            break;
        case 3:
            Console.WriteLine("수강해야 하는 전공 학점: 10학점");
            break;
        case 4:
            Console.WriteLine("수강해야 하는 전공 학점: 18학점");
            break;
        default:
            Console.WriteLine("유효하지 않은 학년입니다.");
            break;
    }
}