using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1...");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            if(A != B)
            {
                if(A > B) B = A;
                else if(B > A) A = B;
            }
            else if(A == B)
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine($"A={A}\nB={B}");
        }
    }
}
