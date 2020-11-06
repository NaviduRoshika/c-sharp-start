using System;
using System.Threading;

namespace my_csharp
{
    public class MultiThreads
    {
        static Thread t1;
        static Thread t2;
        private static Mutex mut = new Mutex();
        private static Semaphore sem = new Semaphore(2,2);
        
        public static void MainXX(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayFirstName));
            t1.Name = "-FNAME-";
            // t1.Start();
            
            t2 = new Thread(new ThreadStart(SayLastName));
            t2.Name = "-LNAME-";
            // t2.Start();

            Thread t3 = new Thread(new ThreadStart(() =>{Console.WriteLine("Hello there thread from lambda");}));
            // t3.Start();
            
            Thread t4 = new Thread(new ThreadStart(delegate()
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine("--------HeHe----------ANNONYMOUS------");
                }
            }));
            // t4.Start();
            
            Thread t5 = new Thread(new ParameterizedThreadStart(SayAName));
            // t5.Start(8);
            
            //DEADLOCk - lock 
            Thread[] threads = new Thread[10];
            Files file = new Files();
            
            for (int i = 120; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start(i);
            }
            
            //DEADLOCK - monitor
            Thread[] threadsMon = new Thread[10];
            Files fileMon = new Files();
            
            for (int i = 120; i < 10; i++)
            {
                threadsMon[i] = new Thread(new ParameterizedThreadStart(file.WriteMonitor));
                threadsMon[i].Start(i);
            }

            //MUTEX
            for (int i = 10; i < 3; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate
                {
                    for (int d = 0; d < 1; d++)
                    {
                        UseResource();
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();    
            }
            //SEMAPHORE
            for (int i = 30; i < 3; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate
                {
                    for (int d = 0; d < 1; d++)
                    {
                        UseResourceSem();
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();    
            }




        }

        public static void SayFirstName()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 500; i++)
            {
                t2.Join();
               // Thread.Sleep(1000);
               // if (i == 31)
               // {
               //     Console.WriteLine(Thread.CurrentThread.Name + " is about to be aborted");
               //     // t1.Abort();
               // } 
               Console.WriteLine(i + " -----Navidu-----");
            }
        }

        public static void SayLastName()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 500; i++)
            { 
                // Thread.Sleep(new TimeSpan(0,0,1));
                Console.WriteLine(i + " -----Roshika-----");
            }
        }
        public static void SayAName(object name)
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 500; i++)
            { 
                // Thread.Sleep(new TimeSpan(0,0,1));
                Console.WriteLine($"{i} -----{name}-----");
            }
        }
        public static void UseResource()
        {
            Console.WriteLine("{0} is requsting the mutex",Thread.CurrentThread.Name);
            mut.WaitOne();

            Console.WriteLine("{0} has entered the critical section",Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("{0} is leaving the critical section",Thread.CurrentThread.Name);
            
            mut.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex",Thread.CurrentThread.Name);
        }
        
        public static void UseResourceSem()
        {
            Console.WriteLine("{0} is requsting the sem",Thread.CurrentThread.Name);
            sem.WaitOne();

            Console.WriteLine("{0} has entered the critical section",Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("{0} is leaving the critical section",Thread.CurrentThread.Name);
            
            sem.Release();
            Console.WriteLine("{0} has released the sem",Thread.CurrentThread.Name);
        }
    }

    public class Files
    {
        public Object thisLock = new Object();
        public  void Write(object path)
        {
            lock (thisLock)
            {
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(1000);
                Console.WriteLine("Writing completed" + path);
            }
        }
        public  void WriteMonitor(object path)
        {
            Monitor.Enter(path);
            try
            {
                Console.WriteLine("Mon Writing in " + path);
                Thread.Sleep(1000);
                Console.WriteLine("Mon Writing completed" + path);
            }
            finally
            {
                Monitor.Exit(path);
            }
        }

        
    }
}