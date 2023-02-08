using System;

namespace Дз_4
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Создать программу для определения синуса угла, ввод угла должен осуществлять
     //пользователь
        static void Main(string[] args)
        {
            int Corner = 0;
            int SineofanAngle = 0;
            Console.Write("Введите число угла = ");
            Corner = int.Parse(Console.ReadLine());
            SineofanAngle = Math.Sign(Corner);
            Console.WriteLine("Синус угла - " + SineofanAngle);
        }
    }
}
