namespace Calculator
{
    public class ResultExample
    {
        private CalculatorExample _calculatorExample;
        public ResultExample(CalculatorExample calculatorExample) => _calculatorExample = calculatorExample;
        
        public virtual double GetResultAdd(double firstNumber, double secondNumber) => _calculatorExample.Add(firstNumber, secondNumber);
        public virtual double GetResultSubtract(double firstNumber, double secondNumber) => _calculatorExample.Subtract(firstNumber, secondNumber);
        public virtual double GetResultMultiply(double firstNumber, double secondNumber) => _calculatorExample.Multiply(firstNumber, secondNumber);
        public virtual double GetResultReminder(int firstNumber, int secondNumber) => _calculatorExample.Reminder(firstNumber, secondNumber);
    }
}