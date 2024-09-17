using System.Xml.XPath;

namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.
            Console.Clear();

            Console.WriteLine("Welcome to my calculator");
            Thread.Sleep(2300);
            Console.Clear();

            int addingResult = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + addingResult);

            Thread.Sleep(2500);
            Console.Clear();

            int substractionResult = Subtract(6, 3);
            Console.WriteLine("The result of subtracting 3 off 6 is: " + substractionResult);

            Thread.Sleep(2500);
            Console.Clear();

            int multiplicationResult = Multiply(2, 3);
            Console.WriteLine("The result of multiplying 2 and 3 is: " + multiplicationResult);

            Thread.Sleep(2500);
            Console.Clear();

            decimal divisionResult = Divide(6, 3);
            Console.WriteLine("The result of diving 6 by 3 is: " + divisionResult);
        }

        // Methods Here
        public static int Add(int a, int b)
        {
            int addResult = a + b; // Code
            return addResult; // Placeholder
        }
        public static int Subtract(int a, int b)
        {
            int subResult = a - b;
            return subResult; // Placeholder
        }
        public static int Multiply(int a, int b)
        {
            int multResult = a * b;// Code
            return multResult; // Placeholder
        }
        public static decimal Divide(int a, int b)
        {
            int divResult = a / b; // Code
            return divResult; // Placeholder
        }
    }
}
