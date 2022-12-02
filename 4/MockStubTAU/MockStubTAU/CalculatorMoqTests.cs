using Moq;
using NUnit.Framework;
using Calculator;
using FluentAssertions;

namespace MockStubTAU
{
    [TestFixture]
    public class CalculatorMoqTests
    {
        [Test]
        public void Add_Mock()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(It.IsAny<int>());
            
            var result = new ResultExample(mock.Object);
            result.GetResultAdd(It.IsAny<int>(), It.IsAny<int>());
            
            mock.Verify(p => p.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
        
        [Test]
        public void Add_Stub()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Add(5, 5)).Returns(10);

            mock.Object.Add(5, 5).Should().Be(10);
        }
        
        [Test]
        public void Subtract_Mock()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Subtract(It.IsAny<int>(), It.IsAny<int>()));
            
            mock.Verify(p => p.Subtract(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
        
        [Test]
        public void Subtract_Stub()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Subtract(5, 5)).Returns(0);

            mock.Object.Subtract(5, 5).Should().Be(0);
        }
        
        [Test]
        public void Multiply_Mock()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Multiply(It.IsAny<int>(), It.IsAny<int>()));
            
            mock.Verify(p => p.Multiply(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
        
        [Test]
        public void Multiply_Stub()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Multiply(5, 5)).Returns(25);

            mock.Object.Multiply(5, 5).Should().Be(25);
        }
        
        [Test]
        public void Reminder_Mock()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Subtract(It.IsAny<int>(), It.IsAny<int>()));
            
            mock.Verify(p => p.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }
        
        [Test]
        public void Reminder_Stub()
        {
            var mock = new Mock<CalculatorExample>();
            mock.Setup(p => p.Subtract(5, 5)).Returns(0);

            mock.Object.Add(5, 5).Should().Be(0);
        }
    }
}