using System;
using System.Timers;
namespace my_csharp
{
    public class Timers
    {
        public static void TimerFunc()
        {
            Timer timer = new Timer();
            timer.Elapsed += (sender, args) => Console.WriteLine("The Timer is Running " + DateTime.Now.ToLongTimeString());
            timer.Interval = 100;
            timer.Enabled = true;

            Console.WriteLine("Press 'X' to Exit");
            while (Console.Read() != 'X')
            {
                
            }
        }
    }
}