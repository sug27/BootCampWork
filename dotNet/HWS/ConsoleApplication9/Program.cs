using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter string to check: ");
            string s = Console.ReadLine();
            if (isPal(s) == true) {
                Console.WriteLine(s + " is a palindrome");
            }
            else {
                Console.WriteLine(s + " is NOT a palindrome");
            }

            Console.ReadLine();
        }
        static bool isPal(string src) {
            bool palindrome = true;
            for (int i = 0; i < src.Length / 2 + 1; i++) {
                if (src[i] != src[src.Length - i - 1]) {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}
