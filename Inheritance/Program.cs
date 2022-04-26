using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Predator dog = new Predator("Собака", "Черный", 7);
            Predator cat = new Predator("Кот", "Рыжий", 4);
            Victim mouse = new Victim("Мышь", "Серый", 1);
            Victim rabbit = new Victim("Кролик", "Белый", 2);
            Console.WriteLine(dog);
            Console.WriteLine(cat);
            Console.WriteLine(mouse);
            Console.WriteLine(rabbit);
            cat.Run(mouse);
            rabbit.Run(dog);*/

            MyDate d = new MyDate(27, 03, 2022);
            Console.WriteLine(d);
            bool check = d.IfLeap();
            check = d.IfToDay();
            d++;
            Console.WriteLine(d);
            check = d.IfToDay();
        }
    }
}
