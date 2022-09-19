using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Polindroms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a palindrome");
            string polindrom = Console.ReadLine();
            char[] mid = polindrom.ToCharArray();
            Array.Reverse(mid);
            string total = new string(mid);
            if (polindrom == total)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadKey();
        }
    }
}
