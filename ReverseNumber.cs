using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDay6
{
    public class ReverseNumber
    {
        public static void call()
        {
            int remainder;
            int reverse = 0;
            int original;
            Console.WriteLine(" Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("reverse num = " + reverse);
        }
    }
}
