using System;

namespace Calculator
{
    public class CalculatorExample
    {
        public virtual double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;

        public virtual double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;

        public virtual double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;

        public virtual double Reminder(int firstNumber, int secondNumber) => firstNumber % secondNumber;
        
    }
}