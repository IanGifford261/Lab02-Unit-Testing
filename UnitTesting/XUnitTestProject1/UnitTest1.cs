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
            string number = Program.withdrawAmt(4000, 3500);
        }

        [Fact]
        public void TestForWithdrawAmtUnderTotalBalance()
        {
            string number = Program.withdrawAmt(2368, 3500);
        }
    }
}
