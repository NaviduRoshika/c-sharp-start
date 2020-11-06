using System;

namespace my_csharp
{
    public class Ref
    {
        public static void MainX(string[] args)
        {
            int x1 = 3;
            ref int x2 = ref x1;
            x2 = 90;
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            ref var retVal = ref ReturnRef();
            Console.WriteLine(retVal);
            retVal = "Gnu";
            Console.WriteLine(retVal);
            retVal = ReturnRef();
            Console.WriteLine(retVal);
        }

        public static ref string ReturnRef()
        {
            string[] arrayOfNames = {"Ella", "Liz", "Claire"};
            return ref arrayOfNames[0];
        }
    }
}