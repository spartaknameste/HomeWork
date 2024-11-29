using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.UppercaseFirstLetter
{
    internal class UppercaseFirstLetterClass
    {
        public static void UppercaseFirstLetter()
        {
            var inputString = Console.ReadLine();
            string[] words = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                var firstLetter = char.Parse(words[i].Substring(0, 1));
                firstLetter = char.ToUpper(firstLetter);
                words[i] = firstLetter + words[i].Substring(1);
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
