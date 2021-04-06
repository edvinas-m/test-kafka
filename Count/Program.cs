using System;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        /*
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
        */
        static async Task Main(string[] args)
        {
            long n = 0;
            long max = -1;
            if (args.Length > 0)
            {
                try
                {
                    max = Convert.ToInt64(args[0]);
                }
                catch
                {
                    max = -1;
                }
            }

            var en = Environment.GetEnvironmentVariables().GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine($"{en.Key} : {en.Value}");
            }

            var ix = Environment.GetEnvironmentVariable("COUNTER-PULSE-INTERVAL-MS");
            int nx = 5000;
            if(ix != null)
            {
                Console.WriteLine($"COUNTER-PULSE-INTERVAL-MS = {ix}");
                try
                {
                    nx = Convert.ToInt32(ix);
                }
                catch 
                { 
                    nx = 5000;
                }

            }

            while (max == -1 || n < max)
            {
                Console.WriteLine($"{DateTime.Now} : {++n}");
                await Task.Delay(nx);
            }
        }
    }
}
