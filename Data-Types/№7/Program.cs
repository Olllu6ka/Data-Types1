using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_7._1
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Windows Forms(.Net framework).
        //Создайте программу для расчета возраста пользователя, по введенному им году рождения
        //необходимо вывести его текущий возраст. (использовать DateTime).
        static void Main(string[] args)
        {
            int YearofBirth = 0, Yourage = 0;
            Console.Write("Введите Год рождения ");
            YearofBirth = int.Parse(Console.ReadLine());
            DateTime date1 = DateTime.Now;
            int CurrentYear = date1.Year;
            Yourage = CurrentYear - YearofBirth;
            Console.WriteLine(Yourage + " - Ваш возраст");

            Console.ReadLine();


        }

    }
}
