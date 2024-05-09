using SimpleMath;

namespace SimpleMath.Tests;

public class SimpleMathTests
{   
    
    [Fact]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        //Generally the code inside of our test methods follows the 3-A format
        //We arrange any objects we may need, not every test will have things arranged.
        //We do some action (aka, call the code in question that is under test)
        //And then we assert something about it's result

        //Arrange
        

        //Act
        bool result = Program.IsPrime(1);

        //Assert
        Assert.False(result);

    }

    [Theory]
    [InlineData(2)]
    [InlineData(4733)]
    public void IsPrime_PrimeNumbers_ReturnsTrue(int numberToTest)
    {
        //Arrange
        

        //Act
        bool result = Program.IsPrime(numberToTest);

        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(234224)]
    public void IsPrime_NotPrimeNumbers_ReturnsFalse(int numberToTest)
    {
        //Arrange
        

        //Act
        bool result = Program.IsPrime(numberToTest);

        //Assert
        Assert.False(result);
    }

}