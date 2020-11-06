using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NewUniverse.BlackHole;
using WorldNameSpace;
using System.IO;
using System.Linq;
using System.Windows.Markup;

namespace my_csharp
{
    enum weekdays
    {
        Sunday, Monday, Tuesday, Wednesday, Friday, Saturdate
    }

    class UseForThis
    {
        string fName;
        private string sName;

       

        public void DispalyName()
        {
            Console.WriteLine(fName + " " + sName);
        }
        /// <summary>
        /// Overloaded method for say name
        /// </summary>
        /// <param name="fName">String for first Name</param>
        /// <param name="sName">String for Second Name</param>
        public void DispalyName(string fName, string sName) //local variable - local scope
        {
            Console.WriteLine(fName + " " + sName);
            Console.WriteLine(this.fName + " " + this.sName);
        }

        public UseForThis()
        {
            fName = "Jon";
            sName = "Doe";
        }

    }
    public delegate void SayHiDelegate();  //IN namespace

    public delegate void SayHappyBirthDay();

    public delegate int Multiply(int n);

    public delegate void SayHiDelegatePara(int x);
    public delegate T DisplayNameDel<T>(T value);
    
    class Program
    {
        static void MainX(string[] args)
        {
            #region 

            /*Person newPer = new Person();
            newPer.FirstName = "Navi";
            newPer.LastName = "Rosh";
            newPer.DOB = new DateTime(1998, 10, 22);

            Person newPer2 = new Person();
            Console.WriteLine(newPer2.FirstName);
            Console.WriteLine(newPer2.LastName);
            Console.WriteLine(newPer2.DOB);
            newPer.sayHi();

            Dog dog1 = new Dog();
            dog1.Bark();

            Animal an1 = new Animal();
            Animal an2 = new Dog();
            Animal an3 = new Bird();
            Animal[] animals = new Animal[3] { an1, an2, an3 };
            foreach (var an in animals)
            {
                an.saySpic();
            }


            Bird kiw = new Bird();
            kiw.Fly();


            Bus veh1 = new Bus();
            Vehicle veh2 = new Car();

            Normal normal = new Normal();
            Normal.First();

            SolarSystem andro = new SolarSystem();
            andro.GoFromPlanet();
            SolarSystem.Earth earth = new SolarSystem.Earth();
            SolarSystem.Neptune neptune = new SolarSystem.Neptune();
            sayHi();

            NewUniverse.PlanetX newUni = new NewUniverse.PlanetX();
            newUni.sayHello();
            // newUniverse.blackHole.nullVoid.sayHello();
            NullVoid.sayHello();

            StructsEx newStruct = new StructsEx();
            newStruct.employeeName = "namal";
            System.Console.WriteLine(newStruct.employeeName);
            string day = weekdays.Monday.ToString();
            weekdays wd = weekdays.Monday;
            System.Console.WriteLine((int)wd);*/
            #endregion


            #region Country exersice
            /*Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();
            countryLanguages.FirstLanguage = Languages.HINDI.ToString();
            countryLanguages.SecondLanguage = Languages.BENGALI.ToString();

            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Germany";
            countryOneInstance.Currency = Currencies.Canadian_dollar_CAD;
            
            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);*/
            #endregion

            #region this keyword

            // UseForThis dis = new UseForThis();
            // dis.DispalyName();
            // dis.DispalyName("Sam","Claffin");
            // dis.DispalyName();

            #endregion

            #region Exception Handling

            // int x = 0;
            // int y = 0;
            // double div = 0;
            //
            // try
            // {
            //     Console.WriteLine("Enter the first Number ");
            //     x = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter thr Second Number ");
            //     y = int.Parse(Console.ReadLine());
            //     div = x / y;
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine("Invalid Dat Enrty " + e);
            // }
            // catch(DivideByZeroException e)
            // {
            //     Console.WriteLine("Can not devide by Zerr "+ e);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("Error Caught " + e);
            //     // throw;
            // }
            // finally
            // {
            //     Console.WriteLine("Result is {0}",div);
            // }



            #endregion

            #region MovieStruct

            // MovieStruct movie1 = new MovieStruct();
            // movie1.MovieName = "The Flash";
            // movie1.MovieRate = 8.3d;
            // movie1.ReleaseDate = new DateTime(2022,10,22);
            // movie1.Countries = new Countries[]{Countries.America,Countries.China,Countries.Korea};
            // movie1.Genres = new Genres[]{Genres.Action,Genres.Animation,Genres.Horror,Genres.SciFi};
            // movie1.Languages = new Languages[] {Languages.English, Languages.French, Languages.Tamil};
            
            // movie1.DispalyMovieData();



            #endregion

            #region Files

            // Directory.CreateDirectory(@"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles");
            // string file = @"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/files.txt";
            //
            // StreamWriter sw = new StreamWriter(file,true);
            // StreamReader sr = new StreamReader(file);
            // // sw.WriteLine("Alex");
            // // sw.WriteLine("James");
            //
            // Console.WriteLine(sr.ReadToEnd());
            // Console.WriteLine("File ended");
            // sw.Close();
            
            // FilesEx.CreateFiles();
            // FilesEx.ReadeFiles();

            #endregion

            #region Crypto

            // string plainText = Console.ReadLine();
            // string enc = CryptoEx.Encrypt(plainText);
            // string dec = CryptoEx.Decrypt(enc);
            // Console.WriteLine("Encrypted  : " + enc);
            // Console.WriteLine("Decrypted  : " + dec);
            #endregion

            #region Colors

            // DateTime date = default;
            // string m1 = "This is a Blue message";
            // string m2 = "This is a green message";
            // string m3 = "This is a red message";
            //
            // Console.ForegroundColor = ConsoleColor.Blue;
            // // Console.BackgroundColor = ConsoleColor.Red;
            // Console.WriteLine(m1);
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine(m2);
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine(date);

            #endregion

            #region Cipher App

            // CeaserCipherApp.CeaserCiperEncryptApp();

            #endregion

            #region collections

            //Collections.ArrayList();
            // Collections.HashTable();
            //Collections.SortedList();
            // Collections.Stack();
            // Collections.Queue();
            // Collections.BitArray();

            #region Ass
            // AnimalsColl dog = new AnimalsColl();
            // AnimalsColl cat = new AnimalsColl();
            // AnimalsColl fly = new AnimalsColl();
            // dog.AnimalName = "The Dog";
            // cat.AnimalName = "Tha Cat";
            // fly.AnimalName = "The Fly";
            //
            // Trainer alex = new Trainer();
            // alex.TrainerName = "Alex";
            //
            // ArrayList newArrL = new ArrayList();
            // newArrL.Add(dog);
            // newArrL.Add(cat);
            // newArrL.Add(fly);
            // newArrL.Add(alex);
            //
            // foreach (var str in newArrL)
            // {
            //     if (typeof(AnimalsColl) == str.GetType())
            //     {
            //         ((AnimalsColl)str).SayHi();
            //         ((AnimalsColl)str).Feed();
            //     }
            //     else
            //     {
            //         ((Trainer)str).SayHi();
            //     }
            //     Console.WriteLine(typeof(AnimalsColl));
            //     
            // }
            #endregion
            
            // Collections.List();
            // Collections.Dictionary();
            // Collections.SortedListGeneric();
            // Collections.SortedDictionary();
            // Collections.StackGeneric();
            // Collections.QueueGeneric();
            // Collections.KeyValuePair();
            // Collections.NameValuePairs();
            
            /*GenericClass<int> sam = new GenericClass<int>();
            sam.Name = "Sam";
            sam.Money = 34;
            sam.Score = 54;
            
            GenericClass<string> alex = new GenericClass<string>();
            alex.Name = "Alex";
            alex.Money = "0.89";
            alex.Score = "zero";

            Console.WriteLine(alex.Score);
            Console.WriteLine(sam.Score);*/
            //Collections.TupleS();

            // var naruto = Tuple.Create(10, 20, 30);
            // Collections.DisplayTupleInfo(naruto);

            #region Tuple Ex

            // List<Tuple<int,string,string,DateTime>> emps = new List<Tuple<int, string, string, DateTime>>();
            //
            // emps.Add(Tuple.Create<int, string, string, DateTime>(100,"Laki","Fernando",new DateTime(2000,10,20)));
            // emps.Add(Tuple.Create<int, string, string, DateTime>(111,"Alex","Fernando",new DateTime(2000,10,20)));
            // emps.Add(Tuple.Create<int, string, string, DateTime>(102,"Nil","Fernando",new DateTime(2000,10,20)));
            // emps.Add(Tuple.Create<int, string, string, DateTime>(103,"Sam","Fernando",new DateTime(2000,10,20)));
            //
            // foreach (var VARIABLE in emps)
            // {
            //     Console.WriteLine(VARIABLE);
            // }
            //
            // emps.Sort();
            // emps.Reverse();
            // foreach (var VARIABLE in emps)
            // {
            //     Console.WriteLine(VARIABLE);
            // }
            

            #endregion
            
            

            #endregion

            #region Recursion

            // Console.WriteLine(Recursion.Factorial(5));

            // string path = @"/media/navidu/New Volume F/Songs";
            // Console.WriteLine(path);
            // Recursion.DisplayFolders(path,0);
            
            // Recursion.LoopThrouhArray(10,20,30,40,50);
            // Recursion.LoopThrouhArray("ABC","DEF","GHI");
            // Recursion.PerformMathOperations(12,3,4);
            
            //ASS
            // RecursiveFileExplorer.DisplayFolders(path,1);
            
            #endregion

            #region Extension methods

            // int x = 90;
            // Console.WriteLine(x.IsGreater(45));
            //
            // string str = "0";
            // Console.WriteLine(str.IsNumber());
            // DateTime date = new DateTime(1998,10,22);
            // Console.WriteLine(date.DateSring());

            // string str = "abc deF ghi";
            // Console.WriteLine(str.FirstLetterCap());

            #endregion

            #region Stopwatch

            // StopwatchApp.StopWatch(300_000_000);

            #endregion

            #region Delegates

            //  PlayerInfoDel p1 = new PlayerInfoDel(DisplayInfo);
            //  PlayerInfoDelName p2 = new PlayerInfoDelName(DisplayInfo);
            //  PlayerInfoDelGoals p3 = new PlayerInfoDelGoals(DisplayInfo);
            //  p1();
            //  p2("Nave");
            //  p3("Sam",56);
            //  Console.WriteLine(p3.Method.Attributes);
            //
            //  Dictionary<int,string> d = new Dictionary<int, string>();
            //  d.Add(1,"Jan");
            //  d.Add(2,"Fem");
            //  d.Add(3,"Jun");
            //  DicValDel dicDel = new DicValDel(DicDel);
            //  dicDel(d);
            //
            //  SayHiDelegate sayHi = null;
            //  
            //  sayHi = new SayHiDelegate(SayAfrica);
            //  sayHi += new SayHiDelegate(SayChina);
            //  sayHi += new SayHiDelegate(SayCongo);
            //  sayHi += new SayHiDelegate(SayJapan);
            //  sayHi += new SayHiDelegate(SaySrilanka);
            //
            //  sayHi();
            //  
            //  DisplayNameDel<int> myNumber = new DisplayNameDel<int>(DisplayName);
            //  Console.WriteLine(myNumber(890));
            //  DisplayNameDel<string> myStrng = new DisplayNameDel<string>(DisplayName);
            //  Console.WriteLine(myStrng("Laki"));
            //  
            //  //ANNONYMOUS METHODS
            // PlayerInfoDel infoAnno = delegate { Console.WriteLine("Hi from the annonymous");};
            // infoAnno();
            //     
            // SayHiDelegatePara sh = delegate (int x){Console.WriteLine("2Hi from the annonymous" + x);  };
            // sh(99);
            //
            // //LAMBDA EXPRESSIONS
            // SayHappyBirthDay hbdAlex= delegate { Console.WriteLine("Happy Birthday ALex"); };
            // hbdAlex();
            // SayHappyBirthDay hbdSam = () =>
            // {
            //     Console.WriteLine("Happy Birthday Sam");
            //     Console.WriteLine("Good Luck");
            // };
            // hbdSam();
            //
            // Multiply mul = n =>
            // {
            //     Console.WriteLine("Multiplication Completed " + n);
            //     return n * n;
            //
            // };
            // Console.WriteLine(mul(7));
            //
            // List<int> list = new List<int>();
            // list.Add(100);
            // list.Add(102);
            // list.Add(103);
            // list.Add(104);
            //
            // var oddList = list.Where(n => n % 2 != 0).ToList();
            // var evenList = list.Where(n => n % 2 == 0).ToList();
            //
            // foreach (var VARIABLE in oddList)
            // {
            //     Console.WriteLine(VARIABLE);
            // }
            // Console.WriteLine("_________________________");
            // foreach (var VARIABLE in evenList)
            // {
            //     Console.WriteLine(VARIABLE);
            // }
            //
            // //FUNC
            // Func<int, int,int> add = AddTwoNumbers;
            // Console.WriteLine(add(5,5));
            //
            // Func<int> add2 = AddTwoNumbers;
            // Console.WriteLine(add2());
            //
            // //ACTION
            // Action actionOne = DisplayInfo;
            // actionOne();
            //
            // Action<string> actionTwo = DisplayInfo;
            // actionTwo("Bale");
            //
            // //Predicate
            // Predicate<int> adult = IsAdult;
            // Console.WriteLine(adult(6));
            //
            // Func<string, string> nameFandL = text => text.ToUpper();
            // Console.WriteLine(nameFandL("navidu"));
            //
            // Func<string,string> nameFandA = delegate(string s) { return s.ToUpper();};
            // Console.WriteLine(nameFandA("Roshika"));
            //
            // Action<string> nameAandA = delegate(string s) { Console.WriteLine($"My name is {s}"); };
            // nameAandA("navidu");
            // Action<string> nameAandL = name => Console.WriteLine($"My name is Lambda {name}");
            // nameAandL("Roshika");




            #endregion

            #region Timers

            // Timers.TimerFunc();


            #endregion

            #region Lambda functions

            // LambdaFunctions.SayHi("Navi");
            // Console.WriteLine(LambdaFunctions.AddNumbers(8, 4));
            //
            // AnimalsLambda ann = new AnimalsLambda();
            // ann.Name = "Balla";
            // Console.WriteLine(ann.Name);



            #endregion

            #region CALC Mukticast del + lambda

            // CalcLambdaDelegates.Calculator(4,5);

            #endregion

            #region NyllableTypes

            // DateTime? myDate = null;
            // DateTime myDate2 = DateTime.Now;
            // Console.WriteLine(myDate ?? myDate2);
            //
            // int? num1 = null;
            // int num2 = 90;
            // Console.WriteLine(num1 ?? num2);
            // num1 = 8;
            // num2 = (int)num1;
            //
            // string str1 = null;
            // string str2 = "STR1 is Null";
            // Console.WriteLine(str1 ?? str2);

            #endregion

            #region LINQ

            var filteredList = new List<Employee>();
            var listOfEmployees = new List<Employee>
            {
                new Employee{EmployeeId=1100,FirstName = "Nave",LastName = "Zone",Salary = 3300m,Age = 35,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1101,FirstName = "Nave1",LastName = "Zone",Salary = 5001m,Age = 14,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1102,FirstName = "Nave2",LastName = "Zone",Salary = 5002m,Age = 35,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1103,FirstName = "Nave3",LastName = "Zone",Salary = 5003m,Age = 40,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1104,FirstName = "Nave4",LastName = "Zone",Salary = 5004m,Age = 12,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1105,FirstName = "Nave5",LastName = "Zone",Salary = 1000m,Age = 32,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1106,FirstName = "Nave6",LastName = "Zone",Salary = 1000m,Age = 20,Appraisal = new List<int>{7,7,8,9}}
            };
            
            //METHOD SYNTAX
            // filteredList = listOfEmployees.Where(e => e.Salary >= 5000 && e.Age > 30).ToList();
            //
            // foreach (var employee in filteredList)
            // {
            //     Console.WriteLine(employee.FirstName + " " + employee.Salary);
            // }
            
            //QUERY SYNTAX
            // filteredList = (from emp in listOfEmployees
            //     where emp.Salary >= 5000 && emp.Age > 30
            //     select emp).ToList();
            // Console.WriteLine("______________________");
            // foreach (var employee in filteredList)
            // {
            //     Console.WriteLine(employee.FirstName + " " + employee.Salary);
            // }
            //
            // filteredList = (from emp in listOfEmployees
            //     orderby emp.Salary ,emp.Age 
            //     select emp).ToList();
            // Console.WriteLine("___________SORT___________");
            // foreach (var employee in filteredList)
            // {
            //     Console.WriteLine(employee.FirstName + " " + employee.Salary + " " + employee.Age);
            // }
            // //QUERY METHOD
            // Console.WriteLine("___________SORTMTHD___________");
            // filteredList = Employee.SortEmployees(filteredList);
            // foreach (var employee in filteredList)
            // {
            //     Console.WriteLine(employee.FirstName + " " + employee.Salary + " " + employee.Age);
            // }
            
            //ASS
            
            // Employee.DisplayQueryData((from emp in listOfEmployees where emp.Salary >= 5000 && emp.Age > 30 select emp).ToList(),"Sorted Employees");
            //
            // Employee.DisplayQueryData((from emp in listOfEmployees where emp.Salary >= 1000 && emp.Age > 3 select emp).ToList());
            #endregion

            #region TimeSpan

            // TimeSpan ts = new TimeSpan(26,10,15);
            // Console.WriteLine(ts);
            //
            // ts = ts.Add(new TimeSpan(0, 0, 30));
            // Console.WriteLine(ts);
            //
            // DateTime d1 = new DateTime(1998,10,22);
            // DateTime d2 = DateTime.Now;
            //
            // TimeSpan age = d2 - d1;
            // Console.WriteLine(age.Days);

            #endregion

            #region Indexer

            Indexers indi = new Indexers();
            indi[0] = "Cat";
            indi[0] = "Bat";
            indi[0] = "Fat";
            Console.WriteLine(indi[0]);

            #endregion

            #region DYNAMIC

            // dynamic dyn = 10;
            // Console.WriteLine("Value is " + dyn);
            // Console.WriteLine("Type is " + dyn.GetType());
            //
            // dyn = "Stange";
            // Console.WriteLine("Value is " + dyn);
            // Console.WriteLine("Type is " + dyn.GetType());

            #endregion







        }

        static void sayHi()
        {
            System.Console.WriteLine("Hello static");
        }

        #region DElegateMethods

        public static bool IsAdult(int x)
        {
            if (x > 18)
                return true;
            else
            {
                return false;
            }
        }
        public static int AddTwoNumbers(int x,int y)
        {
            return x + y;
        }
        
        public static int AddTwoNumbers()
        {
            int x = 50;
            int y = 40;
            return x+y;
        }
        
        public static void DisplayInfo()
        {
            Console.WriteLine("Player : Messy");
        }
        
        public static void DisplayInfo(string name)
        {
            Console.WriteLine("Player : " + name);
        }    
        public static void DisplayInfo(string name,int goals)
        {
            Console.WriteLine("Player : " + name + " Goals : " + goals);
        }

        public static void DicDel(Dictionary<int,string> dic)
        {
            foreach (var val in dic)
            {
                Console.WriteLine(val);
            }
        }

        public static void SayChina()
        {
            Console.WriteLine("I am from China");
        }
        public static void SayCongo()
        {
            Console.WriteLine("I am from Congo");
        }
        public static void SayJapan()
        {
            Console.WriteLine("I am from Japan");
        }
        public static void SaySrilanka()
        {
            Console.WriteLine("I am from Srilanka");
        }
        public static void SayAfrica()
        {
            Console.WriteLine("I am from Africa");
        }

        public static T DisplayName<T>(T value)
        {
            Console.WriteLine("Var Type : " + value.GetType().Name);
            return value;
        }
        
        #endregion





    }

    struct StructsEx
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void SayHi()
        {
            System.Console.WriteLine("Hi from the struct");
        }
    }




}



// Console.WriteLine("Hello World!");
// var test = 0.0;
// Console.WriteLine("Test is : " + test);
// int x = 2;
// test = x;
// Console.WriteLine("Test is : " + test);
// double y = 5.3;
// test = y;
// Console.WriteLine("Test is : " + test);
// float z = 78.7f;
// decimal dc = 0.05m;
// char l = 'a';
// string str = "Apple" + "Sam";
// // test = str;
// Console.WriteLine("Test is : " + test);
// bool isOn = true;
// int x2;
// // x2 = Convert.ToInt32(z);
// x2 = (int)z;
// Console.WriteLine("Number x is : " + x);
// Console.WriteLine("Double y is : " + y);
// Console.WriteLine("Float z  is : " + z);
// Console.WriteLine("Decimal dc  is : " + dc);
// Console.WriteLine("Char l is : " + l);
// Console.WriteLine("String dc is : " + str);
// Console.WriteLine("Bool isOn is : " + isOn);
// Console.WriteLine("X2 is : " + x2);

// DateTime date = new DateTime(1998, 10, 22);
// DateTime myDate = new DateTime(2017, 9, 30, 9, 9, 59);
// string formatDate = string.Format("First Format : {0:dd-MM-yyyy HH:mm:ss}", myDate);
// string formatDate2 = string.Format("Second Format : {0:dddd 'of month' MMMM 'year' yyyy}", myDate);
// string formatDate3 = string.Format("Third Format : {0:\n 'Day' dddd \n 'Month' MMMM \n 'Year' yyyy}", myDate);
// Console.WriteLine("Date is : {0}", date);
// Console.WriteLine("Date is : {0}", myDate.ToShortDateString());
// Console.WriteLine(formatDate);
// Console.WriteLine(formatDate2);
// Console.WriteLine(formatDate3);

// Console.WriteLine("Enter First Number : ");
// int n1 = 10;
// int.TryParse(Console.ReadLine(), out n1);
// Console.WriteLine("Enter Second Number : ");
// int n2 = 10;
// int.TryParse(Console.ReadLine(), out n2);
// int sum = n1 + n2;
// Console.WriteLine("Sum is {0}", sum);
// double d1 = 4.51d;
// double d2 = 4.51f;
// if (d1 == d2)
// {
//     Console.WriteLine(d1 + " " + d2);
// }
// else
// {
//     Console.WriteLine(d1 + " " + d2);
// }

// string str1 = "Game of \a Thrones -         ";
// string str2 = " Season one";

// string str3 = str1.Insert(str1.Trim().Length, str2);
// Console.WriteLine(str1);
// for (int i = 2; i <= 100; i = i + 2)
// {
//     Console.Write(i + " ");
// }
// Console.Write("\n");
// for (int j = 1; j <= 10; j++)
// {
//     for (int z = 1; z <= j; z++)
//     {
//         Console.Write(0);
//     }
//     Console.Write("\n");
// }

// Random rand = new Random();
// // int x = 0;
// Console.WriteLine(rand.Next());
// Console.WriteLine(rand.NextDouble());

// int[] arr1 = new int[5] { 1, 2, 3, 4, 0 };
// string[] arr2 = new string[3] { "aa", "bb", "cc" };
// string[] arr3 = { "ee", "ff", "gg" };
// arr1[3] = 17;
// Console.WriteLine(arr1[3]);
// Console.WriteLine(arr3[2]);



//methods 
// static void Main(string[] args)
//         {
//             int a = 25;
//             int b = 25;
//             int e = 25;
//             int tot = AddNumbers(a, b);
//             Console.WriteLine($"Total of {a} and {b} is {tot}");
//             tot = AddNumbersByRef(ref a, ref b);
//             Console.WriteLine($"Total of {a} and {b} is {tot}");
//             tot = AddNumbersByRef(ref a, ref b, e);
//             Console.WriteLine($"Total of {a} and {b} and {e} is {tot}");
//             tot = AddNumbersByOut(out int c, out int d);
//             Console.WriteLine($"Total of {c} and {d} is {tot}");
//         }

//         static int AddNumbers(int a, int b)
//         {
//             return (a + b);
//         }

//         static int AddNumbersByRef(ref int a, ref int b)
//         {
//             a = 100;
//             b = 100;
//             return (a + b);
//         }

//         static int AddNumbersByRef(ref int a, ref int b, int c)
//         {
//             a = 100;
//             b = 100;
//             return (a + b + c);
//         }

//         static int AddNumbersByOut(out int c, out int d)
//         {
//             c = 1700;
//             d = 100;
//             return (c + d);
//         }

