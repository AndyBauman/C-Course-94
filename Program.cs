using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Do a boolean comparison using a while statement.

//2. Do a boolean comparison using a do while statement.

namespace C_Course_94
{
    class Program
    {
        static void Main(String[] args)
        {

            //int number = 0;
            //while (number < 7)
            //{
            //    Console.WriteLine("While Loop Number {0}", number);
            //    number++;
            //}

            int number2 = 0;
            do
            {
                Console.WriteLine("While Loop Number {0}", number2);
                number2++;
            } while (number2 > 7);


            Console.Read();
        }
             
    }
}
