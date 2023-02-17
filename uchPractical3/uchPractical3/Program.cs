using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UPrac3
{
    public class Program2
    {
        static void Main()
        {
            Math math = new Math();
            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите пункт:\n"
                            + "1 - Посмотреть значения.\n"
                            + "2 - Изменить данные.\n"
                            + "3 - Найти сумму переменных.\n"
                            + "4 - Найти наибольшее число.\n"
                            + "5 - Выйти из системы: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (a)
                {
                    case 1:
                        math.Print();
                        break;
                    case 2:
                        Edit(math);
                        break;
                    case 3:
                        Sum(math);
                        break;
                    case 4:
                        Max(math);
                        break;
                    case 5:
                        return;
                        break;
                    default:
                        Console.WriteLine("Данного пункта не имеется xD");
                        Console.WriteLine(" ");
                        break;
                }
            }
        }

        static void Edit(Math math)
        {
            Console.Write("Введите первую переменную: ");
            math.x = int.Parse(Console.ReadLine());

            Console.Write("Введите вторую переменную: ");
            math.y = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
        }
        static void Max(Math math)
        {
            if (math.x < math.y)
            {
                Console.WriteLine($"наибольшее число: {math.y}\n");
            }
            else { Console.WriteLine($"наибольшее число: {math.x}\n"); }
        }

        static void Sum(Math math)
        {
            int s = math.x + math.y;
            Console.WriteLine($"Сумма чисел {math.x} и {math.y} = {s} \n");
        }
    }
}
