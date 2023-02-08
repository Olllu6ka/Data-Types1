using System;

namespace Дз_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = 0, SecondNumber = 0,SumoftoNumbers = 0, Operation = 0;
            Console.Write("Введите первое число = ");
            FirstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            SecondNumber = int.Parse(Console.ReadLine());
            Console.Write("Cписок операций:"+"\t1)сложение"+"\t2)вычитание"+"\t3)умножение"+"\t4)деление"+"\nВведите какую операцию вы хотите сделать = ");
            Operation = int.Parse(Console.ReadLine());
            if (Operation > 0 && Operation <= 5)
            {
                switch (Operation)
                {
                    case (1):
                        SumoftoNumbers = FirstNumber + SecondNumber;
                        break;
                    case (2):
                        SumoftoNumbers = FirstNumber - SecondNumber;
                        break;
                    case (3):
                        SumoftoNumbers = FirstNumber * SecondNumber;
                        break;
                    case (4):
                        SumoftoNumbers = FirstNumber / SecondNumber;
                        break;
                       
                }
                Console.WriteLine("Сумма двох чисел = " + SumoftoNumbers);
            }
            else
            {
                Console.WriteLine("Ваше число не входит в список действий каркулятора");

            }

        }
    }
}
