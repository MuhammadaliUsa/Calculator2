namespace lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double firstNumber, secondNumber;
            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Please enter the number");
                Console.Write("Enter the first number: ");
            }
            Console.Write("Enter the secondNumber: ");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Please enter the number");
                Console.Write("Enter the second number: ");
            }
            char sign;
            Console.WriteLine(" + ; - ; * ; / ; % ");

            Console.Write("Select the desired icon: ");


            while (char.TryParse(Console.ReadLine(), out sign) || (sign != '+' && sign != '-' && sign != '*' && sign != '/' && sign != '%'))
            {
                Console.WriteLine("Please tick the math operation! ");

                Console.Write("Select the desired icon: ");

            }
            if (secondNumber == 0 && sign == '/')
            {
                Console.WriteLine("Number is not divisible by 0!");

            }

            if (sign == '+')
            {

                Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber + secondNumber}");

            }

            else if (sign == '-')
            {

                Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber - secondNumber}");

            }
            else if (sign == '*')
            {
                Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber * secondNumber}");
            }
            else if (sign == '/')
            {
                Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber / secondNumber}");
            }
            else if (sign == '%')
            {
                Console.WriteLine($"{firstNumber}%{secondNumber}={firstNumber % secondNumber}");
            }
            Console.WriteLine(" ");
            Main(args);
        }


    }
}
