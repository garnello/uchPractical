using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;
using uchPratical4;

namespace uchPractical4
{
    public class Program
    {
        static void Main()
        {
            var sub = new substruction();

            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберите нужный пункт:\n"
                            + "1 - Посмотреть счетчик.\n"
                            + "2 - Уменьшить.\n"
                            + "3 - Увеличить.\n"
                            + "4 - Выйти из системы: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (a)
                {
                    case 1:
                        sub.CounterInfo();
                        break;
                   case 2:
                        Substruction(sub);
                        sub.CounterInfo();
                        break;
                   case 3:
                        Addition(sub);
                        sub.CounterInfo();
                        break;
                   case 4:
                        return;
                        break;
                    default:
                        Console.WriteLine("Такого варианта нет, выберите другой xD");
                        Console.WriteLine("");
                        break;
                }
            }

        }

        static void Substruction(substruction sub)
        {
            sub.counter--;
        }

        static void Addition(substruction sub)
        {
            sub.counter++;
        }
    }
}
