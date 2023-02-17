using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uPrac1
{
    public class Student
    {

        public string secondName { get; set; }
        public string dateOfBirthday { get; set; }
        public int numbersGroups { get; set; }
        public int[] progress { get; set; }

        public Student()
        {
            secondName = "Басхалилов";
            dateOfBirthday = "21.02.2004";
            numbersGroups = 623;
            progress = new int[5] { 5, 5, 5, 5, 5 };
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Фамилия: {secondName} \n" +
                              $"День рождения: {dateOfBirthday} \n" +
                              $"Номер группы студента: {numbersGroups} ");

            Console.Write("Успеваимость студента: ");
            foreach (var j in progress)
            {
                Console.Write(j + " ");
            }
            Console.Write("\n");
        }
    }
}

