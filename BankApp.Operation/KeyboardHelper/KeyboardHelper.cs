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
            for (; ;)
            {
                try
                {
                    input =  Double.Parse(Console.ReadLine());
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
                    else if(!IsStringLetters(input))
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
                   
                    Console.Write(fe+", Enter again please: ");
                    continue;
                }
            }
            return input;
        }
        public static bool IsStringLetters(string value) => 
                                                Regex.IsMatch(value.Trim(), @"^[A-Za-z' ']+$");

        //public static bool Operation(int option)
        //{
        //    bool repeat = false;
        //    switch (option)
        //    {
        //        case 1:
        //            Insert(GetInteger("Enter Amount: "), GetInteger("Enter Customer Id: "));
        //            repeat = true;
        //            break;
        //        case 2:
        //            atm.WithDraw(GetInteger("Enter Amount: "), GetInteger("Enter Customer Id: "));
        //            repeat = true;
        //            break;
        //        case 3:
        //            Console.WriteLine(atm.GetLastFiveTransaction(GetInteger("Enter Customer Id: ")));
        //            repeat = true;
        //            break;
        //        case 4:
        //            Console.WriteLine("Thank you for visiting us.");
        //            repeat = false;
        //            ;
        //            break;

        //    }
        //    return repeat;
        //}

    }
}
