using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** System Exception **");
            Console.Write("\n");

            int a, b, age;

            Console.Write("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            Console.Write("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            try
            {
                int c = a / b;
                Console.WriteLine("Division : {0}", c);
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception Caught : " + e);
            }


            finally
            {
                Console.Write("\n");
                Console.WriteLine("Finally Block Execute Always..");
            }

            //User Defined Exception
            Console.Write("\n");
            Console.WriteLine("**User Defined Exception**");
            Console.Write("\n");


            Console.Write("Enter Your age:");
            age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age > 18 && age < 60)
                {
                    Console.Write("\n");
                    Console.WriteLine("You are Eligible for Voting also You are valid to Driving License ");
                }

                else
                {
                    Console.Write("\n");
                    throw (new InvalidAgeException("You are not Eligible for voating as wel as driving license"));
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine("Exception Caught :" + e);
            }

            Console.Write("\n");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

}
