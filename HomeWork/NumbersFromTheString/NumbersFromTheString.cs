using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.NumbersFromTheString
{
    internal class NumbersFromTheString
    {
        public static void NumberFromString()
        {
            var result = "";
            var inputString = Console.ReadLine();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (char.IsDigit(inputString[i]))
                    result += inputString[i];
            }
            Console.WriteLine(result);
        }
    }
}
