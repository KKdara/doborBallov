using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doborBallov
{
    internal class Program
    {
        static string MakingDiamond(int value)
        {
            string diamond = "";
            for (int i = 1; i < value; i += 2)
            {
                diamond += new string(' ', (value - i) / 2) + new string('*', i) + "\n";
            }
            for (int j = value; j >= 0; j -= 2)
            {
                diamond += new string(' ', (value - j) / 2) + new string('*', j) + "\n";
            }
            return diamond;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter an integer:");
            string input = Console.ReadLine();
            bool result = Int32.TryParse(input, out int value);
            if (result)
            {
                if (value % 2 != 0 & value > 0)
                {
                    Console.WriteLine("Diamond:");
                    Console.WriteLine(MakingDiamond(value));
                }
                else
                {
                    Console.WriteLine("Can't print a diamond.");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong. Please, check your answer or try again later.");
            }
            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
