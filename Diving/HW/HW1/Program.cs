namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор v 0.01");
            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int number2);
            Console.Write("Введите операнд: ");
            string operation = Console.ReadLine();
            Test(operation);

            String Test(string s)
            {
                if (String.IsNullOrEmpty(s))
                    return "Вы не ввели операнд, повторите ввод ";
                return s;
            }
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("Результат выполнения операции (" + operation + ") = " + result);
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine("Результат выполнения операции (" + operation + ") = " + result);
                    break;
                case "/":
                    result = number1 / number2;
                    Console.WriteLine("Результат выполнения операции (" + operation + ") = " + result);
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine("Результат выполнения операции (" + operation + ") = " + result);
                    break;
                default:
                    Console.WriteLine("Для использования программы введите: число знак(+-/*) число");
                    break;
            }
        }
    }
}