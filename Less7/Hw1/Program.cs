namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            double oper1, oper2, result;
            Operation operation;
     
            Console.Write("Введіть перший операнд ");
            oper1 = GetDoubleNumber();
            Console.Write("Введіть другий операнд ");
            oper2 = GetDoubleNumber();
            operation = GetOperation("Введіть операцію 1 - +, 2 - -, 3 - *, 4 - /   ");
            result = DoOperation(oper1, oper2, operation);
            Console.WriteLine("{0} {1} {2} = {3}", oper1, operation, oper2, result);
            Console.ReadKey();
        }

        static Operation GetOperation(string message)
        {
            Operation operation;

            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (System.Enum.TryParse(input, true, out operation) && operation != Operation.None)
                {
                    return operation;
                }
                Console.WriteLine("Неверный ввод. Пожалуйста, введите правильную операцию.");
            }
        }
        static double GetDoubleNumber()
        {
            double number;
            bool resParse = false;
            do
            {
                string input = Console.ReadLine();
                resParse = double.TryParse(input, out number);
            }
            while (!resParse);
            return number;
        }

        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            double result;
            switch (operation)
            {
                case Operation.Add:
                    result = oper1 + oper2;
                    break;
                case Operation.Subtract:
                    result = oper1 - oper2;
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2;
                    break;
                case Operation.Divide:
                    result = oper1 / oper2;
                    break;
                default: throw new ArgumentException();
            }
            return result;
        }
    }
}
