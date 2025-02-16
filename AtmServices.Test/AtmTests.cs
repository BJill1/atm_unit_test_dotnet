namespace AtmServices.Test;
using AtmServices;
public class AtmTests
{
    atm MyAtmTest;
    int InitialBalance = 100;

    public AtmTests()
    {
        MyAtmTest = new atm(InitialBalance);
    }

    [Fact]
    public void Test_withraw()
    {
        var result = MyAtmTest.withdraw(25);
        Assert.True(result);
        Assert.Equal(75, MyAtmTest.GetBalance());
    }

    [Fact]
    public void Test_withdraw_failure()
    {
        var FailureResult = MyAtmTest.withdraw(125);
        Assert.False(FailureResult);
        Assert.Equal(100, MyAtmTest.GetBalance());
    }

    [Fact]
    public void Test_withdraw_deposit()
    {
        var result_withdraw = MyAtmTest.withdraw(25);
        Assert.True(result_withdraw);

        var result_deposit = MyAtmTest.deposit(25);
        Assert.True(result_deposit);
        Assert.Equal(100, MyAtmTest.GetBalance());
    }
}