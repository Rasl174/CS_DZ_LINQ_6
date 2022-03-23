using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_LINQ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier> { new Soldier("Сергей Соколов", "Автомат", "Сержант", 25), new Soldier("Петр Васильев", "Гранатомет", "Рядовой", 10),
                new Soldier("Денис Иванов", "Противотанковое ружье", "Прапорщик", 36), new Soldier("Михаил Синичкин","Пистолет, Мина, Граната","Лейтенант",62),
                new Soldier("Александр Попов","Пистолет","Полковник", 250), new Soldier("Олег Кузнечкин","Винтовка, Пистолет","Капитан", 137)};

            Console.WriteLine("Для вывода имени солдатa и звания введите месяцы службы");

            int userInput = Convert.ToInt32(Console.ReadLine());

            var sortierName = soldiers.Where(soldier => soldier.ServiceLife == userInput).ToList();

            var name = sortierName.ElementAt(0).Name;
            var rank = sortierName.ElementAt(0).Rank;

            Console.WriteLine("Солдато зовут - " + name + "\nЕго звание - " + rank);
        }
    }

    class Soldier
    {
        public string Name { get; private set; }

        public string Arming { get; private set; }

        public string Rank { get; private set; }

        public int ServiceLife { get; private set; }

        public Soldier(string name, string arming, string rank, int serviceLife)
        {
            Name = name;
            Arming = arming;
            Rank = rank;
            ServiceLife = serviceLife;
        }
    }
}
