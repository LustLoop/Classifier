using System;
using Xunit;

namespace Kursach.Tests
{
    public class UnitTest1
    {
        private Program _program;
        public UnitTest1()
        {
            _program = new Program();
        }
        [Fact]
        public void IsPrime()
        {
            var result = _program.IsPrime(1);
            Assert.False(result, "1 should not be prime");
        }
    }
}
