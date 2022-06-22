using System;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Domashno");
            //Брой тухли = x
            //Брой работници = w
            //Вместимост на количката = m
            //Напишете програма, която прочита целите числа x, w и m и пресмята колко най-малко курса трябва да направят работниците за да превозят тухлите.



            Console.WriteLine("Broi tuhli");
            double x = int.Parse(Console.ReadLine());
            if (x > 1000 || x < 1)
            { Console.WriteLine("Допустими са само числа от 1 до 1000"); return; }
            Console.WriteLine("Broi rabotnitsi");
            int w = int.Parse(Console.ReadLine());
            if (w > 1000 || w <1)
            { Console.WriteLine("Допустими са само числа от 1 до 1000"); return; }
            Console.WriteLine("Kapatsitet na kolichkite");
            int m = int.Parse(Console.ReadLine());
            if (m > 1000 || m < 1)
            { Console.WriteLine("Допустими са само числа от 1 до 1000"); return; }
            Console.WriteLine("Minimalen broi kursove");
            double i = x / (m * w);
            Console.WriteLine(Math.Ceiling(i));
        }
    }
}
