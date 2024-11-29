using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ThreeDigitNumber
{
    internal class ThreeDigitNumberClass
    {
        public static void ThreeDigitNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1 && n > 27)
            {
                Console.WriteLine("Недопустимое значение");
                return;
            }
            for (int i = 100; i < 1000; i++)
            {
                string threeDigitNumber = i.ToString();
                var firstNumber = threeDigitNumber[0];
                var secondNumber = threeDigitNumber[1];
                var thirdNumber = threeDigitNumber[2];
                int firstNumberInt = firstNumber - '0';
                int secondNumberInt = secondNumber - '0';
                int thirdNumberInt = thirdNumber - '0';
                if (firstNumberInt + secondNumberInt + thirdNumberInt == n)
                    Console.WriteLine(i);
            }
        }
    }
}
