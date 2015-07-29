using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter Email: ");
            String check = Console.ReadLine();
            checkEmail(check);
            Console.ReadLine();
        }

        public static void checkEmail(String check) {
            int atindex = check.IndexOf("@");
            int dotindex = check.IndexOf(".");
            if((check.Contains("@")) && (check.Contains("."))) {
                if((atindex > 0) && (dotindex < (check.Length - 2))&&(atindex < dotindex)){
                    Console.WriteLine("Email verified");
                }
                else {
                    Console.WriteLine("Email declined");
                } 
            }
        }
    }
}
