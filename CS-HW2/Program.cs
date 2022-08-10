using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLibrary;

namespace CS_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HwPrinter.PrintInfo(2);

            bool f = true;

            while (f)
            {
                Console.WriteLine("==================================================================");
                Console.WriteLine("Мои задачи");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("4 -> Задача 4");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("==================================================================");

                Console.Write("Введите номер задачи: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: \n");
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            Minimal();
                            break;

                        case 2:
                            countAmount();
                            break;

                        case 3:
                            ZeroNum();
                            break;
                        case 4:
                            LoginPass();
                            break;

                        case 0:
                            f = false;
                            break;

                        default:
                            Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                            break;
                    }
                }
            }
        }
        #region tasks
        private static void Minimal()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if (a > b) a = b;
            if (a > c) a = c;
            Console.WriteLine("Min = {0}", a);
            Console.ReadKey();
        }

        private static void countAmount()
        {
            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
        }

        private static void ZeroNum()
        {
            int b = 0;
            while (true)
            {
                Console.Write("Введите число (чтобы завершить подсчет введите 0) : ");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: \n");
                }
                else
                {
                    if (a != 0)
                    {
                        if (a % 2 == 0 || a < 0)
                        { }
                        else
                            b += a;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            Console.WriteLine("Сумма всех ваших нечетных положительных чисел: " + b);
            Console.ReadKey();
        }

        private static void LoginPass()
        {
            string login = "root";
            string password = "GeekBrains";

            int count = 0;
            do
            {
                Console.Write("Введите логин: ");
                string checkLogin = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string checkPassword = Console.ReadLine();

                if (login == checkLogin && password == checkPassword)
                {
                    Console.WriteLine("Добро пожаловать");
                    break;
                }
                Console.WriteLine("Неверно введен логин или пароль");
                Console.WriteLine($"Осталось {2 - count} попыток(ка)");
                if (count == 2)
                {
                    Console.WriteLine("Попробуйте заново");
                }
                ++count;
            } while (count < 3);
        }

        #endregion

    }
}
