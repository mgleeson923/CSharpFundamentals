using System;
using Xunit;

namespace Gradebook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = 5;
            var y = 2;
            var expected = 7;
            var actual = x + y;

          
          Assert.Equal(expected, actual);
        }
    }
}
