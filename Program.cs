// See https://aka.ms/new-console-template for more information
using System;

namespace FizzBuzzTask
{
    class FizzBuzzTask
    {
        public static void Main(string[] args)
        {
            GetFizzBuzz();
        }

        public static void GetFizzBuzz()
        {
            List<string> output = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                string result = "";

                if (i % 3 == 0) result += "Fizz";
                if (i % 5 == 0) result += "Buzz";
                if (i % 7 == 0) result += "Bang";
                if (i % 11 == 0) result = "Bong";
                if (i % 13 == 0)
                {
                    if (result.Contains('B'))
                    {
                        int index = result.IndexOf('B');
                        result = result.Insert(index, "Fezz");
                    }
                    else
                    {
                        result += "Fezz";
                    }
                }
                if (string.IsNullOrEmpty(result)) result = i.ToString();
                output.Add(result);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

        }
    }
}


