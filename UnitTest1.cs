using FibonacciSolution;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fib = new Fibonacci();
            var result = fib.Fib(6);

            Assert.Equal(8, result);
        }
        [Fact]
        public void TestFibonacciWithZero()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(0);
            Assert.Equal(0, result);
        }
        [Fact]
        public void FibonacciWithNegativeNumberShouldReturnSameNumber()
        {
          
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(-5);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void FibonacciWithLargeNumberShouldReturnCorrectResult()
        {
           
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(10);
            Assert.Equal(55, result);
        }

        [Fact]
        public void TestFibonacciWithOne()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(1);
            Assert.Equal(1, result);
            
        }

        [Fact]
        public void TestFibonacciWithSmallNumber()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(6);
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestFibonacciWithNegativeNumber()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(-5);
            Assert.Equal(-5, result);
          
        }

        [Fact]
        public void TestFibonacciWithLargeNumber()
        {
            
            var fibonacci = new Fibonacci();
            var result = fibonacci.Fib(10);
            Assert.Equal(55, result);
        }
    }
}