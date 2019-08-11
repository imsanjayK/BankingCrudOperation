using System;
using System.Text.RegularExpressions;

namespace Support.KeyboardHelper
{
    public class KeyboardHelper
    {
        public static Double ReadNumber(string value)
        {
            Double input = 0.0;
            Console.WriteLine(value);
            for (; ; )
            {
                try
                {
                    input = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Enter again please: ");
                    continue;
                }
            }
            return input;
        }
        public static string ReadLine(string value)
        {
            string input = string.Empty;
            Console.WriteLine(value);
            for (; ; )
            {
                try
                {
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {

                        throw new FormatException("Empty string");
                    }
                    else if (!IsStringLetters(input))
                    {

                        // throw Exception("");
                    }
                    //else ()
                    //{
                    //    Console.WriteLine("");
                    //}


                    break;
                }
                catch (FormatException fe)
                {

                    Console.Write(fe + ", Enter again please: ");
                    continue;
                }
            }
            return input;
        }
        public static bool IsStringLetters(string value) =>
                                                Regex.IsMatch(value.Trim(), @"^[A-Za-z' ']+$");
        public static void Status(bool operation)
        {
            if (operation)
            {
                Console.WriteLine("Transaction Completed");
            }
            else
            {
                throw new Exception("Something wrong");
            }
        }

        public static void print(dynamic value)
        {
           if ( value.GetType().Equals(typeof(System.Collections.Generic.List<dynamic>)))
            {
                foreach (var item in value)
                {
                    Console.WriteLine(item.type+" " + item.amount);
                }
            }
           else if (value.GetType().Equals(typeof(double)))
            {
                    Console.WriteLine($"Balance : {value}");
            }
            else
            {
                throw new Exception("Something wrong");
            }
        }

    }
}
