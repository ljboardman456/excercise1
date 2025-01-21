using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print prompt to ask for first name
            Console.WriteLine("What is your first name?");
            //collect input for first name
            string firstName = Console.ReadLine();
            //print prompt for last name
            Console.WriteLine("What is your last name?");
            //collect user input for last name
            string lastName = Console.ReadLine();    
            //print prompt for age
            Console.WriteLine("What is your age?");
            //collect input for age
            string age = Console.ReadLine();    
            //print prompt for color
            Console.WriteLine("What is your color?");
            //collect input for color
            string color = Console.ReadLine();  
            //print confirmed input info
            Console.WriteLine("Hello, " + firstName + " " +lastName +"! You are " +age + " years old and your favorite color is " + color +".");
            //wait for user input
            Console.ReadLine();
        }
    }
}
