using System;
using Xunit;
using lab02;

namespace XUnitTestlab02
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnANumber()
        {
            //Arrange

            //Act
            int output = ViewBalance(5);
            //Assert
            Assert.Equal(5, output);

        }
    }
}
