using System;

namespace Дз_8
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Имеется 3 переменные типа int x = 10, y = 12, и z = 3; Выполните и рассчитайте результат
        //следующих операций для этих переменных:
        //x += y - x++ * z;
        //z = --x – y* 5;
        //y /= x + 5 % z;
        //z = x++ + y* 5;
        //x = y - x++ * z;
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3, Operation = 0, Sum = 0;
            Console.Write("Cписок операций:" + "\n1)x += y - x++ * z" + "\n2)z = --x – y* 5е" + "\n3)y /= x + 5 % z" + "\n4)z = x++ + y* 5" + "\n5)x = y - x++ * z" +
            "\nВведите какую операцию вы хотите сделать = ");
            Operation = int.Parse(Console.ReadLine());
            switch (Operation)
            {
                case (1):
                    Sum = x += y - x++ * z;
                    break;
                case (2):
                    Sum = z = --x - y * 5;
                    break;
                case (3):
                    Sum = y /= x + 5 % z;
                    break;
                case (4):
                    Sum = z = x++ + y * 5;
                    break;
                case (5):
                    Sum = x = y - x++ * z;
                    break;


            }
            Console.WriteLine("Сумма чисел = " + Sum);
        }
    }
}