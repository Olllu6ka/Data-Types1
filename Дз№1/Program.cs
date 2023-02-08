using System;

namespace Дз_1
{
    class Program
    {
       // Используя Visual Studio, создайте проект по шаблону Console Application.
       // Создайте программу для перевода метров в сантиметры(1м = 100см), ввод метров должен
       //осуществлять пользователь
        static void Main(string[] args)
        {
            int MetersToCentimeters = 100, Usernumber = 0;
            Console.Write("Введите число которое хотите перевести в см =  ");
            Usernumber = int.Parse(Console.ReadLine());
            Usernumber = Usernumber * MetersToCentimeters;
            Console.WriteLine(Usernumber+"  Число в см");
           
        }


    }
}
