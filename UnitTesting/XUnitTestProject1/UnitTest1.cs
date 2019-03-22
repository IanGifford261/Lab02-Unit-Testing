using System;
using Xunit;
using UnitTesting;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestForWithdrawAmtOverTotalBalance()
        {
            decimal overDraw = 4000;
            string number = Program.WithdrawAmt(overDraw);
            Assert.Equal("Please enter an amount below your total balance", number);
        }

        [Fact]
        public void TestForWithdrawAmtUnderTotalBalance()
        {
            decimal underDraw = 2000;
            string number = Program.WithdrawAmt(underDraw);
            Assert.Equal("1525", number);
        }
        [Fact]
        public void TestForDepositAmtOverZero()
        {
            decimal overZero = 25;
            string number = Program.DepositAmt(overZero);
            Assert.Equal("3525", number);

        }
        [Fact]
        public void TestForDepositLessThanZero()
        {
            decimal lessZero = -1;
            string number = Program.DepositAmt(lessZero);
            Assert.Equal("You cannot deposit less than zero!", number);
        }
    }
}
