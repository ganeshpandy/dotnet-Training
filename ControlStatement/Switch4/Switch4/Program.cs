namespace Switch4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, result;
            char operation;
            Console.Write("Enter first number: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = n1 + n2;
                    Console.WriteLine("Addition:" + result);
                    break;
                case '-':
                    result = n1 - n2;
                    Console.WriteLine("sub:" + result);
                    break;
                case '*':
                    result = n1 * n2;
                    Console.WriteLine("multiply:" + result);
                    break;
                case '/':
                    result = n1 / n2;
                    Console.WriteLine("division:" + result);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

        }
    }
}