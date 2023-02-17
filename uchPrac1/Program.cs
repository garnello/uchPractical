using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;


namespace uPrac1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            for (int i = 0; i >= 0; i++)
            {
                Console.Write("Выберете пункт:\n" +
                              "1 - Просмотр информации. \n" +
                              "2 - Изменение данных. \n" +
                              "3 - Выход из системы: ");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.Write("\n");
                        stud.StudentInfo();
                        Console.Write("\n");
                        break;
                    case 2:
                        Console.Write("Выберете пункт: \n" +
                            "1 - Изменить фамилию.\n" +
                            "2 - Изменить дату рождения.\n" +
                            "3 - Изменить номер группы студента.\n" +
                            "4 - Изменить всю информацию о студенте: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                Console.Write("Введите фамилию: ");
                                stud.secondName = Console.ReadLine();
                                stud.StudentInfo();
                                break;
                            case 2:
                                Console.Write("Введите дату рожденя: ");
                                stud.dateOfBirthday = Console.ReadLine();
                                stud.StudentInfo();
                                break;
                            case 3:
                                Console.Write("Введите номер группы: ");
                                stud.numbersGroups = Convert.ToInt32(Console.ReadLine());
                                stud.StudentInfo();
                                break;
                            case 4:
                                EditAll(stud);
                                stud.StudentInfo();
                                break;
                        }
                        break;
                    case 3:
                        return;
                        break;
                    default:
                        Console.WriteLine("Данного варианть не имеется xD");
                        break;
                }
            }
        }
        static void EditAll(Student stud)
        {
            Console.Write("Введите фамилию: ");
            stud.secondName = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            stud.dateOfBirthday = Console.ReadLine();
            Console.Write("Введите номер группы: ");
            stud.numbersGroups = Convert.ToInt32(Console.ReadLine());

            stud.progress = new int[5];
            for (int j = 0; j < stud.progress.Length; j++)
            {
                Console.Write("Введите оценку:");
                stud.progress[j] = int.Parse(Console.ReadLine());
            }
        }
    }
}
