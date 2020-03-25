using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2...");
            double operand1 = Convert.ToDouble(Console.ReadLine().ToString().Replace(".", ","));
            double operand2 = Convert.ToDouble(Console.ReadLine().ToString().Replace(".", ","));
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                break;
                case "/":
                    if(operand2 == 0)
                        Console.WriteLine("На ноль делить нельзя!");
                    else
                        Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                break;
                default:
                Console.WriteLine($"Вы выбрали не верную операцию - {sign}.\nВыберите другую операцию (+, -, /, *)");
                break;
            }
        }
    }
}
