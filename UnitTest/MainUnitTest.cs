using System;
using Xunit;
using MvcMovie.Utilities;

namespace UnitTest
{
    public class MainUnitTest
    {

        [Fact]
        public void MultiplyTest()
        {
            int result = Utility.Multiply(2,2);

            Assert.False(result != 4,"Result should be 4");

        }
    }
}
