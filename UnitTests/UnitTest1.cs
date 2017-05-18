using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
            Console.Write("pass");
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
            Console.Write("fail");
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
