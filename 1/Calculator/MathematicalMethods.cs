namespace Calculator
{
    public class MathematicalMethods
    {
        public double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;

        public double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;

        public double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;

        public int Reminder(int firstNumber, int secondNumber) => firstNumber % secondNumber;

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                throw new Exception("Cannot divide by zero");

            return firstNumber / secondNumber;
        }

        public int Factorial(int number)
        {
            if(number == 0)
                return 1;

            if(number < 0)
                throw new Exception("Cannot count factorial from negative numbers");

            int result = 1;

            for(int i = 1; i<=number; i++)
                result *= i;
            
            return result;
        }
    }
}
