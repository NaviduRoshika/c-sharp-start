using System;
using System.Threading;
using System.Threading.Channels;
using System.Timers;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;


namespace my_csharp
{
    public class Tasks
    {
        private static Timer timer;
        private static Task task8;
        static int dot = 1;
        public static void MainXX(string[] args)
        {
            #region USING ACTION DELEGATE
            //USING ACTION DELEGATE
            Task task = new Task(new Action(SayHi));
            // task.Start();
            

            #endregion

            Console.WriteLine("What is your name ?"); 
            
            // var name = Console.ReadLine();
            // Console.WriteLine("Welcome back " + name);
            // Console.ReadLine();
            
            #region USING ANNONYMOUS METHODS
            Task task2 = new Task(delegate
            {
                Console.WriteLine("Task is Starting");
                Console.WriteLine("Task is Running");
                Console.WriteLine("Hi there");
                Thread.Sleep(10000);
                Console.WriteLine("Task Completed");   
            });
            #endregion


            #region USING LAMBDA EXPRESSIONS
            //USING LAMBDA EXPRESSIONS
            Task task3 =new Task(() =>
            {
                Console.WriteLine("Task is Starting");
                Console.WriteLine("Task is Running");
                Console.WriteLine("Hi there");
                Thread.Sleep(10000);
                Console.WriteLine("Task Completed");
            });
            

            #endregion

            #region PARAMETERIZED TASK ACTION DEL
            //PARAMITIZED TASK - action del
            object nam = "NaviRosh";
            Task task4 = new Task(new Action<object>(SayName),nam);
            // task4.Start();
            

            #endregion

            #region PARAMETERIZED TASK _ ANNONYMOUS
            //PARAMITIZED TASK - annonymous
            nam = "NaviRosh2";
            Task task5 = new Task(delegate(object name){ Console.WriteLine("Your Are {0}",name); },nam);
            // task5.Start();
            #endregion

            #region PARAMETERIZED TASK _ LAMBDA
            
            //PARAMITIZED TASK - lambda
            nam = "NaviRosh3";
            Task task6 = new Task(n=>{ Console.WriteLine("Your Name {0}"); },nam);
            // task6.Start();
            

            #endregion

            #region TASK WITH RETURN VALUE
            //TASK WITH RETURN VALUE
            Task<int> task7 = new Task<int>(() =>
            {
                int num = 1;
                for (int i = 0; i < 100; i++)
                {
                    num++;
                    Console.WriteLine(num);
                }
                return num;
            });
            // task7.Start();
            // Console.WriteLine("Result " + task7.Result);
            

            #endregion

            #region TASK CANCEL & TASK STATE
            //THREAD CANCEL
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken ctoken = cts.Token;
            
            //TASK STATE
            task8 = new Task(() =>
            {
                for (int i = 0; i < 5000000; i++)
                {
                    if (ctoken.IsCancellationRequested)
                    {
                        Console.WriteLine("Task is Cancelled...");
                        timer.Enabled = false;
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i+1);    
                    }

                   
                }
                Console.WriteLine("Task Completed...!");
            });
            
            // task8.Start();
            // timer = new Timer();
            // timer.Elapsed += CheckTheState;
            // timer.Interval = 1;
            // timer.Enabled = true;
            
            // Thread.Sleep(1000);
            // cts.Cancel(); 
            // cts.CancelAfter(300);

            #endregion

            #region TASK WAIT
            Task task9 = new Task(delegate
            {
                Console.WriteLine("Task 1 is Starting");
                Console.WriteLine("Task 1 is Running");
                
                Thread.Sleep(8000);
                Console.WriteLine("Task 1 Completed");   
            });
            // task9.Start();
            // task9.Wait();
            
            Task task10 = new Task(delegate
            {
                Console.WriteLine("Task 2 is Starting");
                Console.WriteLine("Task 2 is Running");
                
                Thread.Sleep(6000);
                Console.WriteLine("Task 2 Completed");   
            });
            // task10.Start();
            // task10.Wait();
            
            Task task11 = new Task(delegate
            {
                Console.WriteLine("Task 3 is Starting");
                Console.WriteLine("Task 3 is Running");
                
                Thread.Sleep(2000);
                Console.WriteLine("Task 3 Completed");   
            });
            // task11.Start();
            

            #endregion
            
            #region TaskFromMethod

            // sayHiTask();
            // AddNumbersTask(1, 2, 3);

            #endregion
            
            #region AYNC AWAIT

            // Console.WriteLine("---------MAIN METHOD-------");
            // RunProcess(1,1_000_000);
            //
            // var dbTask = ConnectToDatabase();
            // Console.WriteLine("Back to the main Method..");
            // if (dbTask.Status == TaskStatus.RanToCompletion)
            // {
            //     Console.WriteLine("Process connect to DB is completed..");
            // }
            // else
            // {
            //     Console.WriteLine("Process connect to DB is NOT completed..");
            // }
            //  
            // RunProcess(2,1_000_000);
            //
            // Console.ReadLine();
            #endregion

            #region Ass - Fastest Task
            CancellationTokenSource ctsTOne = new CancellationTokenSource();
            CancellationToken ctokenTOne = ctsTOne.Token;
            
            CancellationTokenSource ctsTTwo = new CancellationTokenSource();
            CancellationToken ctokenTTwo = ctsTTwo.Token;
            
            int x = 0;
            int y = 0;
            int max = 0;
            Task taskOne = new Task(() =>
            {
                for (x = 1; x <= 100; x++)
                {
                    if (ctokenTOne.IsCancellationRequested)
                    {
                        max = x;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Task 1 {0}",x);    
                    }
                    
                }
            });
            
            Task taskTwo = new Task(() =>
            {
                for (int y = 1; y <= 100; y++)
                {
                    if (ctokenTTwo.IsCancellationRequested)
                    {
                        max = y;
                        break;
                    }else
                    {
                        Console.WriteLine("Task 2 {0}",y);    
                    }
                }
            });
            
            Task taskThree = new Task(() =>
            {
                while (taskOne.Status == TaskStatus.Running && taskTwo.Status == TaskStatus.Running)
                {
                }

                if (taskOne.Status == TaskStatus.RanToCompletion)
                { 
                    ctsTTwo.Cancel();
                    Console.WriteLine("TASK ONE IS COMPLETED!");
                    Console.WriteLine("TASK TWO IS CANCELLED");
                    Console.WriteLine("TASK TWO MAXIMUM IS {0}",max);
                }
                else
                {
                    ctsTOne.Cancel();
                    Console.WriteLine("TASK TWO IS COMPLETED!");
                    Console.WriteLine("TASK ONE IS CANCELLED");
                    Console.WriteLine("TASK ONE MAXIMUM IS {0}",max);
                }
            });
            taskOne.Start();
            taskTwo.Start();
            taskThree.Start();
            
            Console.ReadLine();
            
            #endregion
               
            Task.WaitAll();
        }

        public static void SayHi()
        {
            Console.WriteLine("Task is Starting");
            Console.WriteLine("Task is Running");
            Console.WriteLine("Hi there");
            Thread.Sleep(10000);
            Console.WriteLine("Task Completed");
        }

        public static void SayName(object name)
        {
            Console.WriteLine("Welcome {0}>>>+ ",name);
        }
        
        public static object M()
        {
            object obj = 678;
            object obj2 = 90;
            // return (obj + obj2);
            return obj;
        }
        
        public static void CheckTheState(object sender, ElapsedEventArgs e)
        {
            if (task8.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is Running");
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(".");
                }
            }
            else if (task8.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task Completed..!");
                timer.Enabled = false;
            }
        }

        public  static Task sayHiTask()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hello there from Task Method...");
            });
        }
        
        public static Task AddNumbersTask(params int[] numArr)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Adding Numbers...");
                int tot = 0;
                foreach (var num in numArr)
                {
                    tot += num;
                }

                Console.WriteLine("Total = {0}",tot);
            });
        }

        public static void RunProcess(int processNUmber , int loopCondition)
        {
            Console.WriteLine("\nControl is with the process {0}", processNUmber);
            Console.WriteLine("Process {0} has started..",processNUmber);
            Console.WriteLine("Process {0} is running..",processNUmber);
            for (int i = 0; i <loopCondition; i++)
            {
            }
  
            Console.WriteLine("Process {0} is completed..",processNUmber);
            Console.WriteLine("Control is back to main Method..");
        }


        public static async Task ConnectToDatabase()
        {
         await Task.Run(() =>
            {
                Console.WriteLine("\nControl is with the process connect to DB");
                Console.WriteLine("Process connect to DB has started..");
                Console.WriteLine("Process connect to DB is running..");
                
                Console.WriteLine("Start process in the Await section..");
                Thread.Sleep(10000);
                Console.WriteLine("Process in the await section is complete!");
            });
         Console.WriteLine("Process connect to DB is Completed..");
         Console.WriteLine("Control is with process connect to DB again..\n");
         for (int i = 0; i < 10; i++)
         {
             Console.WriteLine("Getting Data....{0}",i);
         }
         Console.WriteLine("Process get data from DB is complete..");
        }
        
        
    }
}