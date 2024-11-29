using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Binary
{
    internal class BinaryClass
    {
        public static void Binary()
        {
            int n = int.Parse(Console.ReadLine());
            string binary = null;
            while (n > 0)
            {
                binary += (n % 2).ToString();
                n /= 2;
            }
            Console.WriteLine(binary);
        }
    }
}
