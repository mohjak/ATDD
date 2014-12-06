using System;

namespace MyMath
{
    public class Calculator:ICalculator 
    {
        // Fact(5) = 1*2*3*4*5
        // Fact(6) = 1*2*3*4*5*6

        public long Fact(int n)
        {
            if (n < 0)
                throw new InvalidOperationException("n must be a positive number");
            var f = 1;
            for (var i = 1; i <= n; i++)
                f = f * i;
            return f;
        }
    }

    public interface ICalculator
    {
        long Fact(int n);
    }
}
