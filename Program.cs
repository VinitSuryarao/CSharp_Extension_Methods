using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    public static class IntExtensions
    {
        // Extension Method
        // First param must same type of where this method will use
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
