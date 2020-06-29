using System;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing the operator options.
            static void operators()
            {
                Console.WriteLine("Please choose an operator: +, -, *, /. Enter exit to close. All values are case sensitive!");
                string op = Console.ReadLine();

                //writing the addition operator of the calculator
                if (op == "+")
                {
                    Console.WriteLine("Please enter a number: ");
                    int add1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter another number: ");
                    int add2 = Convert.ToInt32(Console.ReadLine());

                    int add = Convert.ToInt32(add1 + add2);
                    Console.WriteLine("The result is {0}", add);

                    operators();
                }
                //writing the subtraction operator
                if (op == "-")
                {
                    Console.WriteLine("Please enter a number: ");
                    int sub1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter another number: ");
                    int sub2 = Convert.ToInt32(Console.ReadLine());

                    int sub = Convert.ToInt32(sub1 - sub2);
                    Console.WriteLine("The result is {0}", sub);
                    operators();
                }
                //multiplication operator
                if (op == "*")
                {
                    Console.WriteLine("Please enter a number: ");
                    int mult1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter another number: ");
                    int mult2 = Convert.ToInt32(Console.ReadLine());

                    int mult = Convert.ToInt32(mult1 * mult2);
                    Console.WriteLine("The result is {0}", mult);
                    operators();
                }
                //division operator
                if (op == "/")
                {
                    Console.WriteLine("Please enter a number: ");
                    int div1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter another number: ");
                    int div2 = Convert.ToInt32(Console.ReadLine());

                    int div = Convert.ToInt32(div1 / div2);
                    Console.WriteLine("The result is {0}", div);
                    operators();
                }
                //exit protocall
                if (op == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Ended...Thanks for using consoleCalculator V.1");
                }
            }
            operators();
        }
    }
}
