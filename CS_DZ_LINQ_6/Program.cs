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
            var sortierSoldier = soldiers.Where(soldier => soldier.ServiceLife == userInput);

            var sortired = from Soldier soldier in sortierSoldier
                           select new
                           {
                               Name = soldier.Name,
                               Rank = soldier.Rank
                           };

            foreach (var soldier in sortired)
            {
                Console.WriteLine("Его имя - " + soldier.Name + "\nЕго звание - " + soldier.Rank);
            }
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
