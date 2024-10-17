namespace _01_Introduction
{
    internal class VariablesandPrimitiveDataTypes
    {
        int age1 = 25;
        int age2;
        //age2=24;

        public VariablesandPrimitiveDataTypes()
        {
            age2 = 24;
            age1 = 26;
            Console.WriteLine(age1);
            Console.WriteLine(age2);

            bool isValid = true;
            Console.WriteLine(isValid);

            sbyte level = 23;
            Console.WriteLine(level);

            short value1 = -1109;
            Console.WriteLine(value1);

            int score = 51092;
            Console.WriteLine(score);

            long range1 = -7091821871L;
            Console.WriteLine(range1);

            byte age = 62;
            Console.WriteLine(age);

            ushort value2 = 42019;
            Console.WriteLine(value2);

            uint totalScore = 1151092;
            Console.WriteLine(totalScore);

            ulong range2 = 17091821871L;
            Console.WriteLine(range2);

            float number = 43.27F;
            Console.WriteLine(number);

            double value = -11092.53D;
            Console.WriteLine(value);

            char ch1 = '\u0042';
            char ch2 = 'x';
            char ch3 = '\n';
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);

            decimal bankBalance = 53005.25M;
            Console.WriteLine(bankBalance);
        }
    }
}

