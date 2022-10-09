namespace Calculator
{
    internal class MathematicalMethods
    {
        public static double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;
        public static double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;
        public static double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;
        public static double Divide(double firstNumber, double secondNumber) => firstNumber / secondNumber;
        public static int Reminder(int firstNumber, int secondNumber) => firstNumber % secondNumber;
        public static int Factorial(int number)
        {
            if(number == 0)
                return 1;

            int result = 1;

            for(int i = 1; i<=number; i++)
                result *= i;
            
            return result;
        }
    }
}
