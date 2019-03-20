using System;
using Xunit;
using static lab02.Program;

namespace XUnitTestlab02
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnANumber()
        {
            //Arrange
            int param = 5;
            //Act
            int output = ViewBalance(param);
            //Assert
            Assert.Equal(5, output);

        }
    }
}
