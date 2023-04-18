using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt16algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool scan = true;
            Console.Write("Введите строку s1: "); string s1 = Console.ReadLine();
            Console.Write("Введите строку s2: "); string s2 = Console.ReadLine();
            Stack <char> stack = new Stack<char>();
            foreach (char c in s1)
            {
                stack.Push(c);
            }
            foreach (char c in s2)
            {
                if (stack.Count == 0 || c != stack.Pop())
                {
                    scan = false;
                    break;
                }
            }
            if (scan)
            {
                Console.WriteLine("s2 является обратной s1");
            }
            else
            {
                Console.WriteLine("s2 не является обратной s1");
            }
            Console.WriteLine("Нажмите любую кнопку для выхода из программы");
            Console.ReadKey();
            
        }
    }
}
