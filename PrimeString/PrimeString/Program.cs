using System;
using System.Text.RegularExpressions;

namespace PrimeString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kata = new Kata();
            string input = "abac";
            bool result1 = kata.PrimeString(input);
            bool result2 = kata.PrimeString2(input);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }

    public class Kata
    {
        public bool PrimeString(string s)
        {
            //coding and coding..
            if (s.Length == 1)
                return true;

            for (var i = 1; i <= s.Length / 2; i++)
            {
                if (s.Length % i != 0)
                    continue;

                var subStr = s.Substring(0, i);
                var split = s.Split(new[] { subStr }, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length == 0)
                    return false;
            }
            return true;
        }

        public bool PrimeString2(string s)
        {
            if (s.Length == 1)
                return true;

            var isAnyDifferent = IsAnyDuplicatedCharacter(s);
            if (!isAnyDifferent)
                return false;

            for (var i = 0; i <= s.Length; i++)
            {
                var subStr = s.Substring(0, i);
                if (subStr == string.Empty)
                    continue;

                var times = Regex.Matches(Regex.Escape(s), subStr).Count;
                if (times > 1 && times * subStr.Length == s.Length)
                    return false;
            }
            return true;
        }

        private bool IsAnyDuplicatedCharacter(string str)
        {
            var charArray = str.ToCharArray();
            var isAnyDifferent = false;
            for (var i = 1; i < charArray.Length; i++)
            {
                if (charArray[i] != charArray[0])
                    isAnyDifferent = true;
            }

            return isAnyDifferent;
        }
    }
}
