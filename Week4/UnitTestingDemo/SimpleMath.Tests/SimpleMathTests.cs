using SimpleMath;

namespace SimpleMath.Tests;

public class SimpleMathTests
{   
    //This fact denotes a test method with no incoming arguments.
    //You can write a ton of Fact tests.
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

    //This test is a theory test, which allows us to pass in arguments to our test method
    //By using InlineData, we can write one test that checks against many test cases.
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