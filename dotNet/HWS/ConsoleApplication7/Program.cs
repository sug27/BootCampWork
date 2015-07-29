using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter string to check: ");
            string check = Console.ReadLine();
            Console.WriteLine("Enter substring to find: ");
            string search = Console.ReadLine();

            int startIndex = IndexOf(check, search);

            Console.Write("Strings match starting at index "+startIndex);
            Console.ReadLine();
        }

        private static int IndexOf(string check, string search) {
            bool match;

            for (int i = 0; i < check.Length - search.Length + 1; ++i) {
                match = true;
                for (int j = 0; j < search.Length; ++j) {
                    if (check[i + j] != search[j]) {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }

            return -1;
        }
    }
}
