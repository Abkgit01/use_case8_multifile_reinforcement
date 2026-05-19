public static class CalculatorTests
{
    public static bool Add_ReturnsExpectedSum()
    {
        var calculator = new Calculator();
        return calculator.Add(2, 3) == 5;
    }

    public static bool Subtract_ReturnsExpectedDifference()
    {
        var calculator = new Calculator();
        return calculator.Subtract(5, 3) == 2;
    }

    public static bool Multiply_ReturnsExpectedProduct()
    {
        var calculator = new Calculator();
        return calculator.Multiply(4, 3) == 12;
    }

    public static bool Divide_ReturnsExpectedQuotient()
    {
        var calculator = new Calculator();
        return calculator.Divide(12, 3) == 4;
    }
}
