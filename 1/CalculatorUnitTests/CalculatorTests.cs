using Calculator;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace CalculatorUnitTests
{
    public class CalculatorTests
    {
        private MathematicalMethods? _sut;

        [SetUp]
        public void Setup() =>  _sut = new MathematicalMethods();

        [TearDown]
        public void Teardown() => _sut = null;

        [Test]
        public void Add_IsReturningCorrectValues() => _sut.Add(5.5, 5).Should().Be(10.5);
        
        [Test]
        public void Subtract_IsReturiningCorrectValues() => _sut.Subtract(5.5, 5).Should().Be(0.5);

        [Test]
        public void Multiply_IsReturningCorrectValues() => _sut.Multiply(5.5, 5).Should().Be(27.5);

        [Test]
        public void Divide_IsReturningCorrectValues_ForNonZeroDivider() 
            => _sut.Divide(5.5, 5).Should().Be(1.1);

        [Test]
        public void Divide_IsThrowingException_WhenDividerIsZero()
             => _sut.Invoking(_sut => _sut.Divide(5.5,0)).Should().Throw<Exception>().WithMessage("Cannot divide by zero");

        [Test]
        public void Reminder_IsReturningCorrectValues() => _sut.Reminder(6, 5).Should().Be(1);

        [Test]
        public void Factorial_IsReturningCorrectValues_ForPositiveNumbers()
            => _sut.Factorial(5).Should().Be(120);

        [Test]
        public void Factorial_IsReturningOne_ForZero() 
            => _sut.Factorial(0).Should().Be(1);

        [Test]
        public void Factorial_IsThrowingException_ForNegativeNumbers()
            => _sut.Invoking(_sut => _sut.Factorial(-1)).Should().Throw<Exception>().WithMessage("Cannot count factorial from negative numbers");
    }
}