using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Практическая работа №11";
                Console.WriteLine("Здравствуйте!");
                Console.WriteLine("Нажмите: Y чтобы продолжить\n\t N чтобы прекратить");
                string select_key = Console.ReadLine();

                switch (select_key)
                {
                    case "Y":

                        try
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Введите строку, состоящую из групп нулей и единиц, разделенных пробелом:");
                            string message = Convert.ToString(Console.ReadLine());

                            if (string.IsNullOrEmpty(message)) // проверка строки
                            {
                                Console.WriteLine("Строка пустая! Вы ничего не ввели.");
                                Console.ReadKey();
                                Environment.Exit(0); // досрочный выход из программы
                            }

                            foreach (char symbol in message)
                            {
                                if (symbol != '0' && symbol != '1' && symbol != ' ')
                                {
                                    Console.WriteLine("Вы вводите недопустимые символы!");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }
                            }

                            Console.WriteLine("Строка:\n" + message);

                            string[] groups = message.Split(' '); // разбиение строки на отдельные массивы

                            int count_group = 0;
                            foreach (string group in groups)
                            {
                                if (group.Length == 5)
                                    count_group++;
                            }

                            if (count_group != 0)
                            {
                                Console.WriteLine("\nГруппы с пятью символами:");
                                foreach (string group in groups)
                                {
                                    if (group.Length == 5)
                                        Console.WriteLine(group);
                                }
                                Console.WriteLine("\nКоличество групп с пятью символами = " + count_group);
                            }
                            else
                            {
                                Console.WriteLine("\nГрупп с пятью символами не обнаружено");
                            }
                            Console.ReadKey();
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Значение аргумента вне диапозона!");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Что-то пошло не так. Ошибка: " + ex.Message);
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.Clear();
                        break;

                    case "N":
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
