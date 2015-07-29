using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number to sum up to: ");
            int end = Convert.ToInt32(Console.ReadLine());
            sumTo(end);
            Console.ReadLine();
        }
        public static void sumTo(int end) {
            int total = 0;
            for (int i = 0; i <= end; i++)
                total += i;
            Console.WriteLine(total);
        }
    }
}
