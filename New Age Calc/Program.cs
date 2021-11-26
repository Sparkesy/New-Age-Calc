using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Age_Calc
{
    internal class Program
    {
        //declare atributes
        public static float grade1;
        public static float grade2;
        public static float grade3;
        
        static void Main(string[] args)
        {
            welcome();
        }
        static void welcome()
        {
            // welcome the user to the program (output)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the grade calculator program");
            Console.WriteLine();
            Console.WriteLine("Press any key to start program");
            Console.ReadKey();
            ask3();
        }
        static void ask3()
        {
            Console.Clear();
            // Ask for first grade percentage (output and input)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter first grade (out of 100): ");
            Console.ForegroundColor = ConsoleColor.White;
            grade1 = float.Parse(Console.ReadLine());
            // Ask for second grade percentage (output and input)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter second grade (out of 100): ");
            Console.ForegroundColor = ConsoleColor.White;
            grade2 = float.Parse(Console.ReadLine());
            // Ask for third grade percentage (output and input)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter third grade (out of 100): ");
            Console.ForegroundColor = ConsoleColor.White;
            grade3 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Thanks, see below your entries. ");
            Console.WriteLine();
            Console.WriteLine(grade1);
            Console.WriteLine(grade2);
            Console.WriteLine(grade3);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue to results");
            Console.ReadKey();
            results();
        }
        static void results()
        { 
            // test mark against grade bounds (process) and show result(output)
            Console.Clear();
            Console.WriteLine("Below are your results");
            Console.WriteLine();
            Console.WriteLine("Assignment 1 is " + grade1);
            Console.WriteLine("Assignment 2 is " + grade2);
            Console.WriteLine("Assignment 3 is " + grade3);
            Console.WriteLine("Your Score is " + (grade1 + grade2 + grade3) / 3 + "%");
            if ((grade1 + grade2 + grade3) / 3 < 40)
            {
                Console.WriteLine("You have Failed!!!");
            }
            else if ((grade1 + grade2 + grade3) / 3 < 55)
            {
                Console.WriteLine("You have a Pass!!!");
            }
            else if ((grade1 + grade2 + grade3) / 3 < 70)
            {
                Console.WriteLine("You have a Merit!!!");
            }
            else
            {
                Console.WriteLine("You have a Distinction!!!");
            }
            Console.WriteLine();
            Console.WriteLine("if you wish to rerun the program press 'y' otherwise press 'n' to exit.");
            string usercommand = Console.ReadLine().ToLower();
            if (usercommand == "y")
            {
                ask3();
               
            }
            else if (usercommand == "n")
            {
                exit();
            }
        }
        static void exit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my program");
            Console.WriteLine("Find more interesting projects at my GitHub Repository: bit.ly/2YDCMYQ ");
            Console.WriteLine();
            Console.WriteLine("Program Developed by Jordan W Sparkes");
            Console.WriteLine("Program Developed using Visual Studio 2022 Proffesional Edition");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}