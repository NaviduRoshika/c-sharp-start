using System;

namespace my_csharp
{
    //Extension methods
    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text,out int result);
        }

        public static string DateSring(this DateTime date)
        {
            return string.Format("{0:dddd dd \nMMMM yyyy}",date); 
        }

        public static string FirstLetterCap(this string str)
        {
            string[] splitted = str.ToLower().Split(' ');
            string newStr = "";
            for (int i = 0; i < splitted.Length; i++)
            {
                
                char c = splitted[i][0];
                if (Char.IsLower(splitted[i][0]))
                {
                    // splitted[i][0] = 'z'; // (int)splitted[i][0] - 32;
                    char[] charArr = splitted[i].ToCharArray();
                    charArr[0] = Char.ToUpper(charArr[0]);
                    splitted[i] = new string(charArr);
                }
            }

            foreach (var VARIABLE in splitted)
            {
                newStr += " " + VARIABLE;
            }
            return newStr.Trim();
        }
    }
}