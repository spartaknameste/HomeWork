using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOP
{
    public record MyDescriptionImmutable
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public MyDescriptionImmutable()
        {
            Name = "Вячеслав";
            SurName = "Мижарёв";
        }
    }
    public record struct MyDescriptionChangeble
    { 
        public int Age { get; set; }
        public string Hobby { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public MyDescriptionChangeble(int age, string hobby, int height, int weight)
        {
            Age = age;
            Hobby = hobby;
            Height = height;
            Weight = weight;
        }
    }
    public static void Main(string[] args)
    {
        var aboutMe = new MyDescriptionChangeble(19, "Играть в Русы против Ящеров", 184, 76);
        Console.WriteLine(aboutMe);
    }

}
