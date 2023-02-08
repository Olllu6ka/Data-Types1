using System;

namespace Дз_9
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу расчета объема - V и площади поверхности -S цилиндра. Объем V
        //цилиндра радиусом – R и высотой – h, вычисляется по формуле: 𝑉 = 𝜋𝑟
        //2ℎ.Площадь S
        //поверхности цилиндра вычисляется по формуле: S = 2πR(R+h). Результаты расчетов выведите на
        //экран.Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту
        //цилинда.
        static void Main(string[] args)
        {
            double R = 0, H = 0, V = 0, S = 0, P = 3.14;
            Console.Write("Введите радиус = ");
            R = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту = ");
            H = int.Parse(Console.ReadLine());
            Console.Write("Что вы хотите узнать 1)V 2)S" + "\nВведите число = ");
            int Operation = int.Parse(Console.ReadLine());
            if (Operation > 0 && Operation <= 2)
            {
                if (Operation == 1)
                {
                    V = (P * (R * R)) * H;
                    Console.WriteLine("Объем - " + V);
                }
                else
                {
                    S = 2 * P * R * (R + H);
                    Console.WriteLine("Площадь поверхности - " + S);
                }
            }
            else
            {
                Console.WriteLine("Ваше число не входит в список действий ");
            }
        }
    }
}
