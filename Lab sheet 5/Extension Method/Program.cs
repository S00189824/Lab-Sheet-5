using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 23.By2less1();
            Console.WriteLine(result);

            string text = "Hello world";

            Console.WriteLine("The number of words in \"{0}\" is {1} ",text,text.W);
        }

        public static int By2less1(this int num)
        {
            return num * 2 - 1;
        }

        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
