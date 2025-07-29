namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Start:
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Write("Enter first number: ");
            double num1;
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Enter second number: ");
            double num2;
            double.TryParse(Console.ReadLine(), out num2);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Enter Operator + , - , * Or /");
            string op = Console.ReadLine().Trim();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        Console.WriteLine("Press any key to restart...");
                        Console.ReadLine();
                        goto Start;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter +, -, *, Or /.");
                    break;
            }
            Console.WriteLine("Press any key to restart...");
            Console.ReadLine();
            Console.Clear();
            goto Start;

        }
    }
}
