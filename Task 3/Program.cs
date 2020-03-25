using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3...");
            int _number = Convert.ToInt32(Console.ReadLine());
            if(_number >= 0 && _number <= 100)
            {
                if(_number >= 0 && _number <= 14)
                {
                    Console.WriteLine($"Число {_number} принадлежит [0 - 14]");
                }
                if(_number >= 15 && _number <= 35)
                {
                    Console.WriteLine($"Число {_number} принадлежит [15 - 35]");
                }
                if(_number >= 36 && _number <= 50)
                {
                    Console.WriteLine($"Число {_number} принадлежит [36 - 50]");
                }
                else if(_number >= 50 && _number <= 100)
                {
                    Console.WriteLine($"Число {_number} принадлежит [50 - 100]");
                }
            }
            else
                Console.WriteLine($"Число {_number} не принадлежит [0 - 100]");
        }
    }
}
