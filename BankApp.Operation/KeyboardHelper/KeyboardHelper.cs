using System;

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
                    Console.WriteLine("Enter again please: ");
                    continue;
                }
                
            }
            return input;
        }
        public static string ReadLine(string value)
        {
            Console.WriteLine(value);
            return Console.ReadLine();
        }
    }
}
