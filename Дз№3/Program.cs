using System;

namespace Дз_3
{
    class Program
    {
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создать программу для определения гипотенузы прямоугольного треугольника,
//используя формулу с = √𝑎
//2 + 𝑏 2, где с – гипотенуза, а b и a катеты прямоугольного
//треугольника.Ввод катетов должен осуществлять пользователь.
        static void Main(string[] args)
        {
            int Hypotenuse = 0 , Leg1 = 0, Leg2 = 0;
            Console.Write("Введите первый число первого вашего катета = ");
            Leg1 = int.Parse(Console.ReadLine());
            Console.Write("Введите первый число второго вашего катета = ");
            Leg2 = int.Parse(Console.ReadLine());
            Hypotenuse = Convert.ToInt32(Math.Sqrt( (Leg1 * Leg1) + (Leg2 * Leg2)));
            Console.WriteLine("Гипотенуза равняется = " + Hypotenuse);
        }
    }
}
