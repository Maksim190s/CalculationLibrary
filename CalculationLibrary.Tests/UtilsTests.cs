using System;
namespace CalculationLibrary.Tests
{
    public class UtilsTests
    {
        [Test]
        public void IsRightTriangleWithSides_3_4_5_expectedTrue()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var expected = true;

            var utils = new Utils();
            var actual = utils.isRightTriangle(a, b, c);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetMaxNumberOfArray_expected77()
        {
            var arr = new[] { 5, -5, 18, 77, -100 };
            var expected = 77;

            var utils = new Utils();
            var actual = utils.GetMaxNumber(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}

