using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program prompts the user to input a numeric number, and then output
    the reverse of that number. 
 * 
 * */

namespace reverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any numbers");// gets input from the user
            int num = int.Parse(Console.ReadLine());// Reads User's input and converts to integer value
            int rev = 0;// iterate through values of current reverse numbers 
                        // and displays the final reverse numbers of User's input 
            while (num > 0)
            {
                int remd = num % 10;// Displays the reminder of number divided by 10
                rev = (rev * 10) + remd;//new rev number is current reverse number * 10 plus the reminder
                num = num / 10;// num is the current number divided by 10
                
            }
            Console.WriteLine("Reverse Numbers = {0}", rev);// Prints the reverse numbers of user's input
            Console.ReadLine();//Reads the output of the reverse numbers 

        }
    }
}
