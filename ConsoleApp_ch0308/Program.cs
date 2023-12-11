using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ch0308
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // 반지름 입력받기
                Console.Write("원의 반지름을 입력하세요: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                // 둘레, 넓이 구하는 공식
                double circ = 2 * Math.PI * radius;
                double area = Math.PI * radius * radius;
                
                // 연산 후 결과값 출력
                Console.WriteLine("원의 둘레: " + circ);
                Console.WriteLine("원의 넓이: " + area);

            // 사용자가 엔터키를 누를 때까지 프로그램을 실행중인 상태로 만듦
            Console.ReadLine();
        }
    }
}
