namespace CalculationLibrary.Tests;

public class SquareCalculationsTests
{
    [Test]
    public void Radius3_expected28_2735()
    {
        var r = 3;
        var expected = 28.2735;

        var squareCalculations = new SquareCalculations();
        var actual = squareCalculations.CalcCircleSquareByR(r);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SquareTriangleWithSides_3_4_5_expected_6()
    {
        var a = 3;
        var b = 4;
        var c = 5;
        var expected = 6;

        var squareCalculations = new SquareCalculations();
        var actual = squareCalculations.CalcSquareTriangleBySides(a, b, c);

        Assert.AreEqual(expected, actual);
    }
}
