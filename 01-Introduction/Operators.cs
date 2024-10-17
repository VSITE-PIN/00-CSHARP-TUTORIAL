namespace _01_Introduction
{
    internal class Operators
    {
        // TODO 09: Create Operators constructor.
        public Operators()
        {
            PrintOperators();
            ArithmeticOperators();
            RelationalOperators();
            LogicalOperators(10, 20);
            UnaryOperator();
            TernaryOperator();
        }
        // TODO 10: Create function that prints operators. Register in constructor.
        public void PrintOperators()
        {
            int firstNumber, secondNumber;
            firstNumber = 10;
            Console.WriteLine("First Number = {0}", firstNumber);

            secondNumber = firstNumber;
            Console.WriteLine("Second Number = {0}", secondNumber);
        }

        // TODO 11: Create function that demonstrates arithmetic operators. Register in constructor.
        public void ArithmeticOperators()
        {
            double firstNumber = 14.40, secondNumber = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
        }

        // TODO 12: Create function that demonstrates relational operators. Register in constructor.
        public void RelationalOperators()
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
        }

        // TODO 13: Create function that demonstrates logical operators. Register in constructor.
        public void LogicalOperators(int first, int second)
        {
            bool result;
            int firstNumber = first, secondNumber = second;

            // OR operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);
        }

        // TODO 14: Create function that demonstrates unary operator. Register in constructor.
        public void UnaryOperator()
        {
            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));
        }

        // TODO 15: Create function that demonstrates ternary operator. Register in constructor.
        public void TernaryOperator()
        {
            int number = 10;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", number, result);
        }
    }
}
