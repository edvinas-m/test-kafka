using System;
using System.Threading;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 0;
            while(true)
            {
                n++;
                Console.WriteLine($"{DateTime.Now} : {n}");
                Thread.Sleep(5000);
            }
        }
    }
}
