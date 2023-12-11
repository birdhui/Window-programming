using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1017p203
{
    internal class Car
    {
        string carNumber;   // 차량번호
        int inTime;
        int outTime;

        public void SetCarNumber(string carNumber)
        {
            this.carNumber = carNumber;
        }

        public string GetCarNumber()
        {
            return this.carNumber;
        }
    }
}
