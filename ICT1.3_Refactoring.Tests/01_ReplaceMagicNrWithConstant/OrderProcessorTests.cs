namespace ICT1._3_Refactoring.Tests.ReplaceMagicNrWithConstant;

using Xunit;
using ICT1._3_Refactoring.ReplaceMagicNrWithConstant;

public class OrderProcessorTests
{
    [Theory]
    [InlineData(150.0, 15.0)]
    [InlineData(100.01, 10.001)]
    [InlineData(100.0, 0.0)]
    [InlineData(99.99, 0.0)]
    public void CalculateDiscount_GivenOrderAmount_CorrectDiscountIsCalculated(decimal orderAmount, decimal expectedDiscount)
    {
        // Arrange
        var orderProcessor = new OrderProcessor();

        // Act
        var actualDiscount = orderProcessor.CalculateDiscount(orderAmount);

        // Assert
        Assert.Equal(expectedDiscount, actualDiscount);
    }

    [Theory]
    [InlineData(6.0, 10.0)]
    [InlineData(5.0, 5.0)]
    [InlineData(4.99, 5.0)]
    [InlineData(5.01, 10.0)]
    public void CalculateShippingCost_GivenOrderWeight_CorrectShippingCostIsCalculated(decimal orderWeight, decimal expectedShippingCosts)
    {
        // Arrange
        var orderProcessor = new OrderProcessor();

        // Act
        var result = orderProcessor.CalculateShippingCost(orderWeight);

        // Assert
        Assert.Equal(expectedShippingCosts, result);
    }


    [Fact]
    public void GetMaximumOrderQuantity_Returns50()
    {
        // Arrange
        var orderProcessor = new OrderProcessor();

        // Act
        var result = orderProcessor.GetMaximumOrderQuantity();

        // Assert
        Assert.Equal(50, result);
    }
}
