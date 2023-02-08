using System;

namespace Дз_6
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Написать программу для расчета скидки за покупку, скидку и цену товара должен
     //осуществлять пользователь
        static void Main(string[] args)
        {
            int PurchaseAmount = 0,Discount = 0,DiscountAmount = 0;
            Console.Write("Введите сумму покупки = ");
            PurchaseAmount = int.Parse(Console.ReadLine());
            Console.Write("Введите процент скидки = ");
            Discount = int.Parse(Console.ReadLine());
            DiscountAmount = (PurchaseAmount * Discount) / 100;
            Console.WriteLine("Сумма скидки составляет = " + DiscountAmount + " грн");
        }
    }
}
