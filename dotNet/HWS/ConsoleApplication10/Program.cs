using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a string to split: ");
            String text = Console.ReadLine();
            String [] array = text.Split(' ');
            Console.WriteLine(array.Length);
            Console.ReadLine();
        }
    }
}
