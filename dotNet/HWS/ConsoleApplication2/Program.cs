using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            printOdd(x);
            Console.ReadLine();
        }
        public static void printOdd(int n) {
            for(int i = 0; i <= n; i++) {
                if((i%2)==1)
                    Console.WriteLine(i);
            }
        }
    }
}
