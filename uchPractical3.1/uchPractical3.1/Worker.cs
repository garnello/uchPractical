using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchPractical3._1
{
    public class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int rate { get; set; }
        public int days { get; set; }

        public Worker() 
        {
            name = "Ярослав";
            surname = "Басхалилов";
            rate = 5;
            days = 11;
        }

        public void GetSalary()
        {
            Console.WriteLine($"Зарплата: {rate * days}\n");
        }
        public void GetInfo() 
        {
            Console.WriteLine($"Имя: {name}\n" +
                              $"Фамилия: {surname}\n" +
                              $"Ставка за день работы: {rate}\n" +
                              $"Отработанные дни: {days}\n");
        }
    }
}
