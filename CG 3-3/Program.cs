using System;

namespace CG_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //a statement is the code it's self. It's the sentence 
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            // an expression is the code working for you. Like doing what you tell it to do.
            // it's made of operators (nouns) and operands (verbs)
            // this is a text example as well as the math example below
            Console.WriteLine("This is an expression. I told the code what to write and also where to end with the semi colon");
            Console.ReadLine();

            // an operator tells the program what to do/ It's the verb of the statment
            // (-, +, *) tells what to do with the ints in the below example

            // an operand is like the noun of the statement
            // the writer controls what the operand is - here I've chosen the int values

            //Operator and operand at work below

            int y = 5;
            int x = 3;
            int z = (x * y) + 5;

            Console.WriteLine("z = (x * y) + 5");

            Console.WriteLine(z);
            Console.ReadLine();



        }
    }
}
