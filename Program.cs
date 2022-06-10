using System;

namespace Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome
            Console.Clear();
            Console.WriteLine("Welcome to the Distance Calcuator!!");
            bool loop = true;
           
           // Loop
            while (loop) {
                // Get Inputs
                Console.WriteLine("Enter x1:");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y1:");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter x2:");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y2:");
                int y2 = Convert.ToInt32(Console.ReadLine());

                // Logic
                double xTotal = Math.Pow(x2-x1,2);
                double yTotal = Math.Pow(y2-y1,2);
                double ans = Math.Sqrt(xTotal+yTotal);

                // Output
                Console.WriteLine($"Distance between points ({x1},{y1}) and ({x2},{y2}) is {ans}.");

                // Ask for loop
                Console.WriteLine("Would you like to continue?");
                string ansLoop = Console.ReadLine().ToLower();
                if (ansLoop == "n" || ansLoop == "no" || ansLoop == "nope") {
                    loop = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
