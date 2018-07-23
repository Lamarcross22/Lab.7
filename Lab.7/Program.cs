using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab._7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter a vaild Name");
            string input2 = "";
            string input3 = "";
            string input = Console.ReadLine();
            bool repeat = true;
            while (repeat)
            {
                if (Regex.IsMatch(input, @"^[A-Z]{1}[a-z]{0,29}$"))

                {

                    Console.WriteLine("You've enter a vaild Name");
                    repeat = false;
                }

                else

                {

                    Console.WriteLine("Nice try! next time please do it right!");
                    Console.WriteLine("Please enter a vaild Name");

                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Please enter a vaild Email");
            Console.ReadLine();
              
            repeat = true;
            while (repeat)

            {

                if (Regex.IsMatch(input, @"^[A-Z]{ 5,30}[^abc]@[A-Z]{5,10}[^abc].[A-Z]{2,3}$"))
                {
                    Console.WriteLine("You have enter a vaild email");
                    repeat = false;
                }

                else
                {
                    Console.WriteLine("You failed to meet expectations");
                    Console.WriteLine("Please enter a vaild Email.");
                    input2 = Console.ReadLine();
                }



            }
            Console.WriteLine("please enter a phone number in the format of 313-673-0892");
            Console.ReadLine();

            repeat = true;
            while(repeat)
            {
                if 
                  (Regex.IsMatch(input, @"\d\d\d-\d\d\d-\d\d\d\d$"))

                { Console.WriteLine("You have enter a vaild phone");
                    repeat = false;

                }
                else
                {
                    Console.WriteLine("You failed to meet expectations");
                    Console.WriteLine("Please enter a phone number in the following format 333-333-3333");
                    Console.ReadLine();

                }
                Console.WriteLine("Please enter a vaild date);
            }

           



            


        }
    }
}
