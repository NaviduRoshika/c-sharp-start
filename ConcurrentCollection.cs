using System;
using System.Collections.Concurrent;
using System.Threading;

namespace my_csharp
{
    public class ConcurrentCollection
    {
        public static void MainXX(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
        
            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1 Started....");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread 1 Added Number - {0}",i);
                    bag.Add(i);
                
                }

                Console.WriteLine("Thread 1 is completed...");
            });
            
            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread 2 Started....");
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine("Thread 2 Added Number - {0}",i);
                    bag.Add(i);
                
                }

                Console.WriteLine("Thread 2 is completed...");
            });
            
            Thread t3 = new Thread(() =>
            {
                t1.Join();
                t2.Join();
                Console.WriteLine("Thread 3 Started....");
                foreach (var num in bag)
                {
                    Console.WriteLine("In Bag - {0}",num);
                }
                Console.WriteLine("Thread 3 is completed...");
            });
            
            t1.Start();
            t2.Start();
            t3.Start();
            
            
        }
        
        
    }
}