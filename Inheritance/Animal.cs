using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Wight { get; set; }
        protected Animal(string _n, string _c, int _w)
        {
            Name = _n;
            Color = _c;
            Wight = _w;
        }
    }
    class Predator : Animal
    {
        string type;
        public Predator(string _n, string _c, int _w) : base(_n, _c, _w)
        {
            type = "Хищник";
        }
        public override string ToString()
        {
            return $"Имя: {this.Name} | Вес: {this.Wight} | Цвет: {this.Color} | Тип: {this.type}\n";
        }
        public void Run(Victim v)
        {
            Console.WriteLine($"{this.Name} хочет сьесть {v.Name}\n");
        }
    }
    class Victim : Animal
    {
        string type;
        public Victim(string _n, string _c, int _w) : base(_n, _c, _w)
        {
            type = "Жертва";
        }
        public override string ToString()
        {
            return $"Имя: {this.Name} | Вес: {this.Wight} | Цвет: {this.Color} | Тип: {this.type}\n";
        }
        public void Run(Predator p)
        {
            Console.WriteLine($"{this.Name} убегает от {p.Name}\n");
        }
    }
}
