using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstvalue, secondtvalue;

                try
                {
                    Console.WriteLine("Добро пожаловать в калькулятор!");
                    Console.Write("Введите первое число: ");
                    firstvalue = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    secondtvalue = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода. Повторите ещё раз.");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("Ввыберите операцию:" +
                        "\n1 - сложение" +
                        "\n2 - вычитание" +
                        "\n3 - деление" +
                        "\n4 - умножение");
                Console.WriteLine("Ввод: ");
                int symbol = Convert.ToInt32(Console.ReadLine());
                switch (symbol)
                {
                    case 1:
                        Console.WriteLine($"Операция сложения.\nОтвет: {firstvalue + secondtvalue}.");
                        break;
                    case 2:
                        Console.WriteLine($"Операция вычитания.\nОтвет: {firstvalue - secondtvalue}.");
                        break;
                    case 3:
                        Console.WriteLine($"Операция деления.\nОтвет: {firstvalue / secondtvalue}.");
                        break;
                    case 4:
                        Console.WriteLine($"Операция умножения.\nОтвет: {firstvalue * secondtvalue}.");
                        break;
                    default:
                        Console.WriteLine("Не известная операция. Повторите ещё раз.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
