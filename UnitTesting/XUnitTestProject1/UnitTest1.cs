using System;
using Xunit;
using UnitTesting;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //Will need to refactor this test
        [Fact]
        public void TestForWithdrawAmtOverTotalBalance()
        {
            decimal overDraw = 4000;
            string number = Program.WithdrawAmt(overDraw);
            Assert.Equal("Please enter an amount below your total balance", number);
        }

        //[Fact]
        //public void TestForWithdrawAmtUnderTotalBalance()
        //{
        //    string number = Program.WithdrawAmt(2368, 3500);
        //}
        //[Fact]
        //public void TestForDepositAmtOverZero()
        //{
        //    string number = Program.DepositAmt(25, 3500);

        //}
        //[Fact]
        //public void TestForDepositLessThanZero()
        //{
        //    string number = Program.DepositAmt(-1, 3500);
        //}
    }
}
