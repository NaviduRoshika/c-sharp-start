using System;

namespace my_csharp
{
    public class CalcLambdaDelegates
    {
        public delegate void Calc(double n1 , double n2);

        public static void Calculator(double num1,double num2)
        {
            Calc cal = new Calc(Addition);
            cal += new Calc(Subtraction);
            cal += new Calc(Division);
            cal += new Calc(Multiplication);
            cal += new Calc(Remainder);

            cal(num1,num2);
        }
        private static void Addition(double n1, double n2) => Console.WriteLine($"[+] {n1} + {n2} = {n1 + n2}");
        private static void Subtraction(double n1, double n2) => Console.WriteLine($"[-] {n1} - {n2} = {n1 - n2}");
        private static void Division(double n1, double n2) => Console.WriteLine($"[/] {n1} / {n2} = {n1 / n2}");
        private static void Multiplication(double n1, double n2) => Console.WriteLine($"[x] {n1} x {n2} = {n1 * n2}");
        private static void Remainder(double n1, double n2) => Console.WriteLine($"[%] {n1} % {n2} = {n1 % n2}");

    }
}