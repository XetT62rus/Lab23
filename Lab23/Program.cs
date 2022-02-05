using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            FactorialAsunc(m);
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i < n+1; i++)
            {
                factorial *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(factorial);
        }
        static async void FactorialAsunc(int n)
        {
            await Task.Run(()=>Factorial(n));
        }
    }
}
