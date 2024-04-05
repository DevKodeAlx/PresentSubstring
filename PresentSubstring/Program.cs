using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string mainString = "Rock 'n' roll is good for your soul.";
            string subString = "roll is good";
            
            Console.WriteLine(mainString);
            Console.WriteLine(subString);

            if (mainString.Contains(subString))
            {
                Console.WriteLine("the substring is present in the string. ");
            }
            else
            {
                Console.WriteLine("The substring is not present in the string. ");
            }
            
            Console.ReadLine();
        }
    }
}
