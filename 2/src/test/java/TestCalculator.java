
import org.junit.After;
import org.junit.Test;
import org.junit.Assert;
import org.junit.Before;

public class TestCalculator {
    private Calculator _sut;

    @Before
    public void Before() {
        _sut = new Calculator();
    }

    @After
    public void After() {
        _sut = null;
    }

    @Test
    public void Add_IsReturningCorrectValues() {
        int a = 15; int b = -20;
        int expectedResult = -5;

        long result = _sut.Add(a, b);
        Assert.assertEquals(expectedResult, result);

    }

    @Test
    public void Factorial_IsReturningCorrectValues() {
        long n = 19;
        long expectedResult = 121645100408832000L;
        long result = _sut.FactorialUsingForLoop(n);
        Assert.assertEquals(expectedResult, result);
    }


    @Test(expected = IllegalArgumentException.class)
    public void Factorial_IsThrowingException_ForTooBigNumber() {
        long n = 21;
        _sut.FactorialUsingForLoop(n);
    }

    @Test
    public void Subtract_IsReturningCorrectValues() {
        int a = 25; int b = 20;
        int expectedResult = 5;
        long result = _sut.Subtract(a, b);
        Assert.assertEquals(expectedResult, result);
    }


    @Test
    public void Multiply_IsReturningCorrectValues() {
        int a = 10; int b = 25;
        long expectedResult = 250;
        long result = _sut.Multiply(a, b);
        Assert.assertEquals(expectedResult, result);
    }

    @Test
    public void Divide_IsReturningCorrectValues() {
        int a = 56; int b = 10;
        double expectedResult = 5.6;
        double result = _sut.Divide(a, b);
        Assert.assertEquals(expectedResult, result,0.00005);
    }

    @Test(expected = IllegalArgumentException.class)
    public void  Divide_IsThrowingException_WhenDividerIsZero() {
        int a = 15; int b = 0;
        _sut.Divide(a, b);
    }

    @Test
    public void Reminder_IsReturningCorrectValues() {
        int a = 13;
        int b = 4;
        int expectedResult = 1;
        int result = _sut.Reminder(a, b);
        Assert.assertEquals(expectedResult, result);
    }
    @Test
    public void Exponentiation_IsReturningCorrectValues(){
        float a = 5;
        float b = 2;
        float expectedResult = 25;
        float result = _sut.Exponentiation(a,b);
        Assert.assertEquals(expectedResult,result,0.00000001);
    }
    @Test(expected = IllegalArgumentException.class)
    public void Exponentiation_IsThrowingException_WithZero(){
        float a = 5;
        float b = 0;
        _sut.Exponentiation(a,b);
    }
}