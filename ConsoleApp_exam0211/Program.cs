// See https://aka.ms/new-console-template for more information
Console.WriteLine("인치를 입력하시오");

string sInch;
float nInch;
sInch = Console.ReadLine();
bool result = float.TryParse(sInch, out nInch);
if (result)
{
    nInch = float.Parse(sInch);
    Console.WriteLine(nInch + "inch = " + nInch * 2.54 + "cm");
}
else
    Console.WriteLine(sInch + "는 숫자가 아닙니다");
