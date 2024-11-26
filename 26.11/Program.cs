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



            string s = "Мой номер - 89-37-029-45-33";

            string pattern = @"\d{2}-\d{2}-\d{3}-\d{2}-\d{2}";

            match_string(s, pattern);

            string pochta = "Моя почта - fdhdfsdfhkf@gmail.com";

            string pattern1 = @"[a-z0-9]+\@[a-z]+\.[a-z]+$";

            validacia(pochta, pattern1);
        
        }

        public static void proverka()
        {

            Console.Write("Пример: 89-37-029-45-33 \n");
            Console.Write("Введите номер телефона:");
            string number = Console.ReadLine();


            if (number == "89-37-029-45-33")
            {
                Console.WriteLine("Номер введен правильно!");
            }
            else
            {
                Console.WriteLine("Номер введен неправильно!");
            }
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

        public static void validacia(string input,string match)
        {
            Match k = Regex.Match(input,match);
            if (k.Success)
            {
                Console.WriteLine("Почта найдена!");

            }
            else
            {
                Console.WriteLine("Почта не найдена!");
            }
        }
    }
}
