using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uPrac2
{
    public class Program2
    {
        static void Main()
        {
            List<Train> tr = new List<Train>()
            {
                new Train(1, "Вокзал Питер", "22.21"),
                new Train(2, "Вокзал Москва", "12.51"),
                new Train(3, "Вокзал Екатеренбург", "02.30"),
            };
            Console.WriteLine("Введите номер поезда: ");
            var numTrain = int.Parse(Console.ReadLine());

            foreach (Train train in tr)
            {
                if (train.trainNumber == numTrain)
                {
                    train.TrianInfo();

                }
            }
        }
    }
}