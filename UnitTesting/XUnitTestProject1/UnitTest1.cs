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
            string execeptionTest = "You cannot withdraw more than your total balance";
            string number = Program.WithdrawAmt(4000, 3500);
            Assert.Equal(execeptionTest, number);
        }

        [Fact]
        public void TestForWithdrawAmtUnderTotalBalance()
        {
            string number = Program.WithdrawAmt(2368, 3500);
        }
        [Fact]
        public void TestForDepositAmtOverZero()
        {
            string number = Program.DepositAmt(25, 3500);

        }
        [Fact]
        public void TestForDepositLessThanZero()
        {
            string number = Program.DepositAmt(-1, 3500);
        }
    }
}
