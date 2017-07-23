using System;

namespace PrimeString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kata = new Kata();
            string input = Console.ReadLine();
            bool result = kata.PrimeString(input);
            Console.WriteLine(result);
        }
    }

    public class Kata
    {
        public bool PrimeString(string s)
        {
            //coding and coding..

            if (s.Length == 1)
                return true;

            for (int i = 1; i <= s.Length / 2; i++)
            {
                if (s.Length % i != 0)
                    continue;

                string subStr = s.Substring(0, i);

                string[] split = s.Split(new[] { subStr }, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length == 0)
                    return false;
            }
            return true;
        }
    }
}
