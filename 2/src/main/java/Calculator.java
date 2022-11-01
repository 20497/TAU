public class Calculator {

    public Calculator() {
    }

    public int Add(int a, int b) {
        return a + b;
    }

    public int Subtract(int a, int b) {
        return a - b;
    }


    public long Multiply(long a, long b) {
        return a * b;
    }


    public double Divide(double a, double b) {
        double result;

        if (b == 0) {
            throw new IllegalArgumentException("Cannot divide by zero");
        } else {
            result = a/b;
        }
        return result;
    }

    public long FactorialUsingForLoop(long n) {
        long fact = 1;

        if (n > 20) {
            throw new IllegalArgumentException("Too big number for long type");
        }
        else
            for (long i = 2; i <= n; i++) {
                fact = fact * i;
            }
            return fact;
        }


    public int Reminder(int a, int b) {return a % b;}

    public float Exponentiation(float a, float b)
    {
        float base=a;
        float power=b;
        int result=1;

        if(power!=0){
            for(int i=1;i<=power;i++)
            {
                result*=base;
            }
        }
        else if(power == 0) {
            throw new IllegalArgumentException("Wrong number!!!!");
        }
        return result;
        }
    }





