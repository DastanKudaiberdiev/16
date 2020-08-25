using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _16
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Cooking Time");

            Task<Taskclass> t1 = Start(1);
            Task<Taskclass> t2 = Start(2);
            Task<Taskclass> t3 = Start(3);
            Task<Taskclass> t4 = Start(4);

            await Task.Delay(15000);
        }

        private static async Task<Taskclass> Start(int numb)
        {
            var cook = Stopwatch.StartNew();
            double doub;
            Random random = new Random();
            int toast = random.Next(1, 4);
            for (int i = 1; i <= 4; i++)
            {
                await Task.Delay(toast * 1500);
                Console.WriteLine($"{i}-runner finished ({numb}-Food)");
            }
            cook.Stop();
            doub = cook.Elapsed.TotalSeconds;
            Console.WriteLine($"\n{numb}-Food Finished, time: {doub: 0.00} sec.");
            return new Taskclass();
        }
        internal class Taskclass
        {

        }
    }
}
