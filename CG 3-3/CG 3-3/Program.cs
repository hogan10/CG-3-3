using System;

namespace CG_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a program to demonstrate your understanding of basic C# skills.
            Define the following C# terms in your own words: statement, expression, operator, operand as code comments.  
            After each definition, write some code that demonstrates the use of each of these.  
            Upload your program to a new repository called CG 3-3
            */

            //a statement is the action I am asking the program to take. Below I am asking it to write "hello there! How are you?"
            //a statement is always ended and complete with the semi colon. Without the semi colon the program does not know what this is.
            Console.WriteLine("Hello there! How are you?");
            Console.ReadLine();


            //an expression is the code making the program do what you are asking it to do. Below I will ask it to write "It is almost August!"
            //it will understand the statement and execute the expression because I used writeline and readline

            Console.WriteLine("It is almost August!");
            Console.ReadLine();

            //Operators are things like *,+,-,/ the operand is the noun. In the following example + is the operator and 5 and 10 are the operands

            int x = 5;
            int y = 10;
            int z = x + 10;

            Console.WriteLine(z = x + 10);
            Console.ReadLine();


        }
    }
}
