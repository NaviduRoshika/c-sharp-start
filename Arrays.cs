using System;

namespace my_csharp
{
    public class Arrays
    {
        public static void MainXX(string[] args)
        {
            #region MULTI DEMENSIONAL ARRYAS

            string[,] strArray2D = new string[,]{{"One","Two"},{"Three","Four"},{"Five","Six"}};
            int[,] intArray2D = new int[,]{{1,2,3},{4,5,6},{7,8,9}};

            Console.WriteLine("2D STR ARRAY");
            foreach (var str in strArray2D)
            {
                Console.Write(str + " ");
            }
            
            Console.WriteLine("\n2D INT ARRAY");
            foreach (var num in intArray2D)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nNumber of elements " + intArray2D.Length);
            Console.WriteLine("2D INT ARRAY");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(intArray2D[i,j] + " ");
                }
            }

            #endregion


            #region JAGGED ARRAYS
            int[][] jaggedArray = new int[3][];

            string[][] jaggedStringArray = {new[] {"A", "B", "C"},new[] {"D", "E", "F","G","H"},new[]{"I","J"}};

            jaggedArray[0] = new int[3] {1,2,3};
            jaggedArray[1] = new int[5] {4,5,6,7,8};
            jaggedArray[2] = new int[4] {9,10,11,12};
            Console.WriteLine("\n2D JAGGED INT ARRAY");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
            }
            Console.WriteLine("\nJagged Array Rows " + jaggedArray.Length);
            
            Console.WriteLine("\n2D JAGGED STRING ARRAY");
            for (int i = 0; i < jaggedStringArray.Length; i++)
            {
                for (int j = 0; j < jaggedStringArray[i].Length; j++)
                {
                    Console.Write(jaggedStringArray[i][j] + " ");
                }
            }
            Console.WriteLine("\nJagged Array Rows " + jaggedStringArray.Length);
            

            #endregion

            #region JAGGED MULTIDEMENTIONAL ARRAY

            int[][,] jaggMulti = new int[3][,];
            jaggMulti[0] = new int[,]{{1,2},{3,4}};

            #endregion
           
        }
    }
}