using System;

namespace Дз_2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
        //Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Console.Write("Введите радиус круга = ");
            double R = double.Parse(Console.ReadLine());
            double Answer = (Pi * (R * R));
            Console.Write(Answer + "  Площадь круга");

        }
    }
}
