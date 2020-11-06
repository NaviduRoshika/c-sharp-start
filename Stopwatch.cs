using System;
using System.Diagnostics;
namespace my_csharp
{
    public class StopwatchApp
    {
        public static void StopWatch(long l)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Loop(l);
            watch.Stop();

            Console.WriteLine("Milliseconds " + watch.Elapsed.Milliseconds);
            Console.WriteLine("Total Ms" + watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Total Seconds" + watch.Elapsed.TotalSeconds);
            Console.WriteLine("Seconds " + watch.Elapsed.Seconds);
        }

        public static void Loop(long l)
        {
            for (int i = 0; i <l; i++)
            {
                Console.WriteLine("Loop " + i);
            }

            Console.WriteLine("Loop Done");
        }
    }
}