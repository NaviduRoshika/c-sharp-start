using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace my_csharp
{
    public class Collections
    {

        public static void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("First");
            arrayList.Add("Second");
            arrayList.Add("Third");
            arrayList.Add("Fourth");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------INSERT---------------");
            arrayList.Insert(2,"Hello");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------INDEX---------------");
            //INDEX
            Console.WriteLine(arrayList[4]);
            //COUNT
            Console.WriteLine("----------COUNT---------------");
            Console.WriteLine(arrayList.Count);
            //SORT
            Console.WriteLine("----------SORT---------------");
            arrayList.Sort();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //REVERSE
            Console.WriteLine("----------REVERSE---------------");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //REMOVE
            Console.WriteLine("----------REMOVE---------------");
            arrayList.Remove("First");
            arrayList.RemoveAt(2);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //REMOVE ALL
            // arrayList.Clear();
            // Console.WriteLine("----------REMOVE ALL---------------");
            // Console.WriteLine(arrayList.Count);
            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item);
            // }
            //CONTAINS
            Console.WriteLine("----------CONTAINS---------------");
            Console.WriteLine(arrayList.Contains("Third"));
            //GET RANGE
            Console.WriteLine("-----------Get Range---------------");
            ArrayList arrL = new ArrayList();
            arrL = arrayList.GetRange(0, 2);
            foreach (var item in arrL)
            {
                Console.WriteLine(item);
            }

        }

        public static void HashTable()
        {
            Hashtable hashTable = new Hashtable();
            
            //ADD
            hashTable.Add("Microsoft","USA");
            hashTable.Add("Nasa","USA");
            hashTable.Add("Toyota","Japan");
            hashTable.Add("Samsung","China");
            
            //Displaying
            Console.WriteLine("--------Display---------");
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key + "\t\t- " + item.Value);
            }
            //Count
            Console.WriteLine("--------COUNT---------");
            Console.WriteLine(hashTable.Count);
            //REMOVE
            Console.WriteLine("--------REMOVE---------");
            hashTable.Remove("nasa");
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key + "\t\t- " + item.Value);
            }
            //CONTAINS
            Console.WriteLine("--------CONTAINS---------");
            Console.WriteLine(hashTable.Contains("Nasa"));
            Console.WriteLine(hashTable.ContainsValue("USA"));
            //COPY TO ARRAYLIST
            Console.WriteLine("--------COPY TO ARRAYLIST---------");
            ArrayList values = new ArrayList(hashTable.Values);
            ArrayList keys = new ArrayList(hashTable.Keys);
            foreach (var item in values)
            {
                Console.WriteLine("Value - " + item);
            }
            foreach (var item in keys)
            {
                Console.WriteLine("Key - " + item);
            }
        }

        public static void SortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("cat","Jan");
            sortedList.Add("bat","Feb");
            sortedList.Add("tat","Mar");
            sortedList.Add("hat","Apr");
            
            //DISPALY
            Console.WriteLine("----------Display-------");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key+" - " + item.Value);
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + " : " +sortedList.GetByIndex(i));
            }
            
            //INDEX
            Console.WriteLine("----------INDEX-------");
            Console.WriteLine(sortedList["cat"].ToString());
            Console.WriteLine(sortedList.GetByIndex(1));
            
            //COUNT
            Console.WriteLine("----------COUNT-------");
            Console.WriteLine(sortedList.Count);
            //REMOVE
            Console.WriteLine("----------REMOVE-------");
            sortedList.Remove("cat");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key+" - " + item.Value);
            }
            //CONTAINS
            Console.WriteLine("----------CONTAINS-------");
            Console.WriteLine(sortedList.ContainsValue("Apr"));
            
            //COPY TO ARRAYLIST
            Console.WriteLine("--------COPY TO ARRAYLIST---------");
            ArrayList values = new ArrayList(sortedList.Values);
            ArrayList keys = new ArrayList(sortedList.Keys);
            foreach (var item in values)
            {
                Console.WriteLine("Value - " + item);
            }
            foreach (var item in keys)
            {
                Console.WriteLine("Key - " + item);
            }
            
        }

        public static void Stack()
        {
            Stack stack = new Stack();
            
            //ADD
            stack.Push("Sam");
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Alex");
            
            
            //Dispaly
            Console.WriteLine("-------Dispaly---------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            
            //REMOVE
            Console.WriteLine("-------REMOVE---------");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }

        public static void Queue()
        {
            Queue queue = new Queue();
            
            //Add
            queue.Enqueue("1 - Tom");
            queue.Enqueue("2 - Sam");
            queue.Enqueue("3 - Jon");
            
            //Get
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            
            //Remove
            Console.WriteLine("-------remove---------");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public static void BitArray()
        {
            bool[] boolArray = new bool[4];
            boolArray[0] = true;
            boolArray[1] = false;
            boolArray[2] = true;
            boolArray[3] = false;
            
            BitArray firstBit = new BitArray(4);
            BitArray result = new BitArray(4);
            BitArray secondBit = new BitArray(boolArray);
            
            //Setting Value
            firstBit.Set(0,true);
            firstBit.Set(1,true);
            firstBit.Set(2,false);
            firstBit.Set(3,false);

            foreach (var item in firstBit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
            foreach (var item in secondBit)
            {
                Console.WriteLine(item);
            }
            //AND
            Console.WriteLine("----------AND----------");
           // result = firstBit.And(secondBit);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //NOT
            Console.WriteLine("----------NOT----------");
            //result = firstBit.Not();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        
        //GENERIC COLS
        public static void List()
        {
            //CREATE
            List<string> firstList = new List<string>();
            IList<string> secondList = new Collection<string>();
            //ADDING
            firstList.Add("England");
            firstList.Add("China");
            firstList.Add("Japan");
            firstList.Add("Germany");
            secondList.Add("Joke");
            
            //Dispaly
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            
            //INDEX
            Console.WriteLine("---------INDEX------------");
            firstList[2] = "Korea";
            
            //COUNT
            Console.WriteLine("---------COUNT------------");
            Console.WriteLine(firstList.Count);
            
            //SORTING
            Console.WriteLine("----------SORT---------");
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            
            //REVERSE
            Console.WriteLine("----------REVERSE---------");
            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            
            //REMOVE
            Console.WriteLine("----------REMOVE-------");
            firstList.Remove("China");
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            //REMOVE ALL
            Console.WriteLine("----------REMOVE ALL-------");
            //firstList.Clear();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            //CONTAINS
            Console.WriteLine("----------CONATINS-------");
            Console.WriteLine(firstList.Contains("Korea"));
            
        }

        public static void Dictionary()
        {
            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            
            Dictionary<int,string> names = new Dictionary<int, string>()
            {
                {1,"ALex"},
                {2,"James"},
                {3,"Jon"},
            };
            dictionary.Add("one","Black");
            dictionary.Add("two","White");
            dictionary.Add("three","Red");
            
            //Display
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary.Keys.ElementAt(i));
                Console.WriteLine(dictionary.Values.ElementAt(i));
                Console.WriteLine(dictionary[dictionary.Keys.ElementAt(i)]);
            }
            
            //INDEX
            Console.WriteLine("----------INDEX---------");
            dictionary["one"] = "Pink";
            Console.WriteLine(dictionary["one"]);
            
            //COUNT
            Console.WriteLine("-----------COUNT---------");
            Console.WriteLine(dictionary.Count);
            //Try get value
            Console.WriteLine("--------------TRY GET VALUE--------");
            dictionary.TryGetValue("two", out string result);
            Console.WriteLine("R " + result);
            //REMOVE
            Console.WriteLine("-------REMOVE--------");
            dictionary.Remove("three");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------NAMES----------");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }

        public static void SortedListGeneric()
        {
             SortedList<string,string> sortedList = new SortedList<string,string>();
             
             //ADD
             sortedList.Add("Jack","0771234567");
             sortedList.Add("Sam","123456789");
             sortedList.Add("Tuck","34567890");
             sortedList.Add("Rick","09876456");
             
             //Displaying
             foreach (var item in sortedList)
             {
                 Console.WriteLine(item.Key + " - " + item.Value);
             }
             
             //INDEX
             Console.WriteLine("----------INDEX------------");
             sortedList["Jack"] = "12345556";
             Console.WriteLine(sortedList["Jack"]);
             //TRYGETVALUE
             Console.WriteLine("----------T G V------------");
             sortedList.TryGetValue("Sam", out string name);
             Console.WriteLine(name);
             
        }

        public static void SortedDictionary()
        {
            SortedDictionary<int,string> sortedDic = new SortedDictionary<int, string>();
            sortedDic.Add(1,"Blue");
            sortedDic.Add(3,"Red");
            sortedDic.Add(45,"Balck");
            sortedDic.Add(5,"Pink");
            
            //display
            foreach (var item in sortedDic)
            {
                Console.WriteLine(item.Key + " - " +item.Value);
            }
            //index
            sortedDic[4] = "WHhite";
            foreach (var item in sortedDic)
            {
                Console.WriteLine(item.Key + " - " +item.Value);
            }
        }

        public static void StackGeneric()
        {
            Stack<string> ram = new Stack<string>();
            ram.Push("VS Code");
            ram.Push("Photoshop");
            ram.Push("Sublime");

            foreach (var rram in ram)
            {
                Console.WriteLine(rram);
            }
        }

        public static void QueueGeneric()
        {
            Queue<DateTime> arrivals = new Queue<DateTime>();
            arrivals.Enqueue(new DateTime(1998,10,22));
            arrivals.Enqueue(new DateTime(2013,2,3));

            foreach (var date in arrivals)
            {
                Console.WriteLine(date);
            }
        }
 
        public static void KeyValuePair()
        {
            var capitals = new List<KeyValuePair<string,string >>();
            
            capitals.Add(new KeyValuePair<string, string>("Russia","Moscow"));
            capitals.Add(new KeyValuePair<string, string>("Sri Lanka","Colombo"));
            capitals.Add(new KeyValuePair<string, string>("Portugal","Lisbon"));
            capitals.Add(new KeyValuePair<string, string>("Japan","Tokoyo"));

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            } 
        }

        public static void NameValuePairs()
        {
            NameValueCollection cities = new NameValueCollection();
            
            //ADD
            cities.Add("Germany","Berlin");
            cities.Add("Germany","Hamburg");
            cities.Add("Germany","Frankfurt");
            cities.Add("Italy","Rome");
            
            //Display
            foreach (string item in cities)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item + " - " + cities[item]);
            }
            //SET
            Console.WriteLine("-----------SET---------");
            cities.Set("Japan","Tokoyo");
            cities.Set("Japan","Tokoyo");
            cities.Add("Japan","Tokoyo");
            cities.Add("Japan","Tokoyo");
            cities.Set("Germany","Frank");
            cities.Set("Japan","Tokoyo");
            foreach (string item in cities)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item + " - " + cities[item]);
            }
            
            //Contains
            Console.WriteLine("---------CONTAIN---------");
            Console.WriteLine(cities.HasKeys());
            
            //REMOVE
            Console.WriteLine("---------REMOVE---------");
            cities.Remove("Japan");
            foreach (string item in cities)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item + " - " + cities[item]);
            }
            
        }

        public static void TupleS()
        {
            var empInfo = new Tuple<int,string,string,DateTime,bool>(100,"Alex","Stark",new DateTime(1998,10,22),false);
            Console.WriteLine(empInfo);
            Console.WriteLine(empInfo.Item1);

            var studentInfo = Tuple.Create(99, "Laki", "Fernando", new DateTime(1998, 2, 1));
            Console.WriteLine(studentInfo);
            
            var nested = new Tuple<int,int,int,int,int,int,int,Tuple<int, string, string, DateTime, bool>>
                (10,20,30,40,50,60,70,Tuple.Create(99, "Laki", "Fernando", new DateTime(1998, 2, 1),true));
            Console.WriteLine(nested);
            Console.WriteLine(nested.Rest);
            
            //Install Package "System.ValueTuple"
            (int playerNo, string, int) ronaldo = (7, "Sansa", 55);
            var student = (sNo: 234, sName: "Violno",ronaldo);
            Console.WriteLine("New PKG " + ronaldo);
            Console.WriteLine("New PKG 2" + student.ronaldo.Item2);
            Console.WriteLine(ronaldo.Item1);
            Console.WriteLine(ronaldo.playerNo);

            var tList = new List<(int a, int b, int c)>();
            tList.Add((7,14,21));
            tList.Add((4,8,12));
            tList.Add((10,20,30));

            foreach (var VARIABLE in tList)
            {
                Console.WriteLine(VARIABLE);
            }

        }

        public static void DisplayTupleInfo(Tuple<int,int,int> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
        }
        
    }

    public class GenericClass<T>
    {
        private string name;
        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        private T money;
        public T Money
        {
            get { return money;}
            set { money = value; }
        }
        
        private T score;
        public T Score
        {
            get { return score;}
            set { score = value; }
        }
        
    }
    struct AnimalsColl
    {
        private string animalName;
        public string AnimalName
        {
            get { return animalName;}
            set { animalName = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hiii...I am {0}",animalName);
        }

        public void Feed()
        {
            Console.WriteLine($"{animalName} is Eating...");
        }

    }

    struct Trainer
    {
        private string trainerName;
        public string TrainerName
        {
            get { return trainerName;}
            set { trainerName = value; }
        }
        
        public void SayHi()
        {
            Console.WriteLine("Hiii...I am {0}",trainerName);
        }
    }
}