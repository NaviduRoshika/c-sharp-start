using System;
using System.Collections.Generic;
using System.Linq;

namespace my_csharp
{
    public class IEnumerable
    {
        public static void Main(string[] args)
        {
            // IEnumerable
            //READONLY
            IEnumerable<int> result = from num in Enumerable.Range(1, 10) select num;

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            double avg = result.Average();
            Console.WriteLine(avg);

            List<int> list = result.ToList();
            int[] arr = result.ToArray();
            
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);

            result = list.AsEnumerable();
            Console.WriteLine("New List-------");
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n----------------");
            Console.WriteLine("In Enumerator");
            // IEnumerator<>
            IEnumerator<int> inrt = list.GetEnumerator();
            while (inrt.MoveNext())
            {
                Console.Write(inrt.Current + " ");
            }
            //YIELD
            Console.WriteLine("\nYield-----------");
            foreach (var res in PerformMathOps(5,23))
            {
                Console.WriteLine(res);
            }





        }

        public static IEnumerable<double> PerformMathOps(int numOne, int numTwo)
        {
            yield return numOne + numTwo;
            yield return numOne - numTwo;
            yield return numOne * numTwo;
            yield return Math.Round((double)numOne /(double)numTwo,2);
        }
    }
}