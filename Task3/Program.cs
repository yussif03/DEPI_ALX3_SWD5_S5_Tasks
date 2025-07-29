namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] addNumbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine(Add(addNumbers));
            Console.WriteLine(Add(8,2));

            Console.WriteLine("------------------");

            double[] subtractNumbers = { 100, 20, 30, 40, 5 };
            Console.WriteLine(Subtract(subtractNumbers));
            Console.WriteLine(Subtract(100, 20));

            Console.WriteLine("------------------");

            double[] multiplyNumbers = { 2, 3, 4, 5 };
            Console.WriteLine(Multiply(multiplyNumbers));
            Console.WriteLine(Multiply(3, 2));

            Console.WriteLine("------------------");

            double[] divideNumbers = { 100, 2, 5 };
            Console.WriteLine(Divide(divideNumbers));
            Console.WriteLine(Divide(100, 2));

            Console.WriteLine("------------------");

            Console.WriteLine(IsEven(4));
            Console.WriteLine(IsEven(5));
            Console.WriteLine(IsOdd(3));
            Console.WriteLine(IsOdd(6));

            Console.WriteLine("------------------");

            printPrimaryNumbers(1, 30);
            printPrimaryNumbers(0, 1);

            Console.WriteLine("------------------");

            printPyramid();


        }

        #region Calculator Methods

        static double Add(params double[] arr)
        {
            if (arr.Length == 0)
                return 0;
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }

        static double Subtract(params double[] arr)
        {
            if (arr.Length == 0)
                return 0;
            double result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result -= arr[i];
            }
            return result;
        }

        static double Multiply(params double[] arr)
        {
            if (arr.Length == 0)
                return 0;
            double result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }

        static double Divide(params double[] arr)
        {
            if (arr.Length == 0)
                return 0;
            double result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return double.NaN; // Return NaN to indicate an error
                }
                result /= arr[i];
            }
            return result;
        }

        #endregion

        #region Odd/Even Methods

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        #endregion

        #region Primary Numbers Method

        static void printPrimaryNumbers(int s, int e)
        {
            if (e < 2)
            {
                Console.WriteLine("No primary numbers in this range.");
                return;
            }
            Console.Write("Prime Numbers : ");
            if (s < 2)
                s = 2;
            for (int i = s; i <= e; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i ; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        #endregion

        #region Pyramid Method

        static void printPyramid()
        {
            int space = 12;
            for (int i = 1; i <= space; i++)
            {
                for (int j = 1; j <= space - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }


        #endregion

    }
}
