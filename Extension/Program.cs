using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "This long blog post summary needs to be shorent to be shown in the list.";

            Console.WriteLine(str.Shorten(5));
        }
    }


    public static class StringExtensions{
        public static string Shorten(this string str, int noOfWords)
        {
            if(string.IsNullOrEmpty(str)) throw new ArgumentNullException();

            var words = str.Split(' ');

            if (words.Length <= noOfWords) return str;

            return string.Join(" ", words.Take(noOfWords));
        }
    }
}
