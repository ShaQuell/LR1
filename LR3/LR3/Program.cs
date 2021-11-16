using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Це калькулятор. Введіть перше число, бажану операцію та друге число у такому форматі: 1 + 2.\nБудь ласка, ставте пробіли між елементами \nОперації: +: додавання, -: віднімання, *: множення");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            String[] expressions = { s1, s2, s3 };
            String pattern = @"(\d+)\s+([-+*])\s+(\d+)";
            foreach (var expression in expressions) foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(expression, pattern)) 
            {
                    int value1 = Int32.Parse(m.Groups[1].Value);
                    int value2 = Int32.Parse(m.Groups[3].Value);
                    switch (m.Groups[2].Value)
                    {
                        case "+":
                            Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
                            break;
                        case "-":
                            Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
                            break;
                        case "*":
                            Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
                            break;
                    }
            } 
        }
    }
}
