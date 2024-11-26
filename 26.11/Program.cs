using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _26._11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // \d - это любой цифровой символ;

            // \w - это любая буква или цифра;

            // \. - это что угодно;

            // {} - кол-во включений;



            string s = "Мой номер - 89-37-029-45-3";

            string pattern = @"\d{2}-\d{2}-\d{3}-\d{2}-\d{2}";

            match_string(s, pattern);


        
        }

        public static void match_string(string input, string match)
        {
            Match m  = Regex.Match(input, match);

            if (m.Success)
            {
                Console.WriteLine("Номер найден!");

            }
            else
            {
                Console.WriteLine("Номер не найден!");
            }
        }
    }
}
