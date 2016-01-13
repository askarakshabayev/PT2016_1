using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string s = Console.ReadLine();
            string[] token = s.Split(); // 5 6 
            a = int.Parse(token[0]);
            b = int.Parse(token[1]);
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
