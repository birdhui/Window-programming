// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kg을 입력하시오");

string sKg;
float nKg = 0;
sKg = Console.ReadLine();
bool result = float.TryParse(sKg, out nKg);
if (result)
{
    nKg = float.Parse(sKg);
    Console.WriteLine(nKg + "Kg = " + nKg * 2.20462262 + "pound");
}
else
    Console.WriteLine(sKg + "는 숫자가 아닙니다");
