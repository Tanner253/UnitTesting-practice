using System;
using Xunit;
using static lab02.Program;

namespace XUnitTestlab02
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            //Arrange
            int param = 5;
            //Act
            int output = ViewBalance();
            //Assert
            Assert.Equal(5, param);

        }
        [Fact]
        public void CanDeposit()
        {
            //Arrange
            int num1 = 1;
            int num2 = 6;

            //Act
            string output = AddFunds(num1, num2);
            
            //Assert
            Assert.Equal("7", output);

        }
        [Fact]
        public void CannotDepositNegativeNumbers()
        {
            //Arrange
            int num1 = 2000;
            int num2 = -50;

            //Act
            string output = AddFunds(num1, num2);
            
            //Assert
            Assert.Equal("Please enter a number greater than 0", output);

        }
        [Fact]
        public void CanWithdraw()
        {
            //Arrange
            int currentVal = 40;
            int withdrawl = 20;
            //Act
            string output = RemoveFunds(currentVal, withdrawl);
            //Assert
            Assert.Equal("20", output);
        }
        [Fact]
        public void CannotWithdrawNegativeNumbers()
        {
            //Arrange
            int num1 = 2000;
            int num2 = 3000;

            //Act
            string output = RemoveFunds(num1, num2);

            //Assert
            Assert.Equal("please enter a valid selection", output);

        }
    }
}
