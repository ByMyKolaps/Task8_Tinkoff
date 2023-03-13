using Task8_Tinkoff;

namespace Tests
{
    public class Tests
    {
        [TestCase(10, 5, new double[] { 4.5, 2.0, 4.5, 4.0, 5.5, 4.0, 5.5, 2.0 }, 5.104166, 3.020833)]
        [TestCase(10, 5, new double[] { 4.5, 4.0, 4.5, 2.0, 5.5, 2.0, 5.5, 4.0 }, 5.09615, 2.98076)]
        [TestCase(10, 5, new double[] { 5.5, 4.0, 5.5, 2.0, 4.5, 2.0, 4.5, 4.0 }, 4.89583, 3.020833)]
        [TestCase(10, 5, new double[] { 5.5, 2.0, 5.5, 4.0, 4.5, 4.0, 4.5, 2.0 }, 4.90384, 2.98076)]

        [TestCase(10, 5, new double[] { 1.0, 1.5, 3.0, 1.5, 3.0, 2.5, 1.0, 2.5 }, 1.25, 1.875)]
        [TestCase(10, 5, new double[] { 3.0, 1.5, 1.0, 1.5, 1.0, 2.5, 3.0, 2.5 }, 2.5, 1.875)]
        [TestCase(10, 5, new double[] { 3.0, 2.5, 1.0, 2.5, 1.0, 1.5, 3.0, 1.5 }, 2.5, 12.5 / 6)]
        [TestCase(10, 5, new double[] { 1.0, 2.5, 3.0, 2.5, 3.0, 1.5, 1.0, 1.5 }, 1.25, 12.5 / 6)]
        public void Task8_Tests(double x, double y, double[] corners, double expectedX, double expectedY)
        {
            var actual = Program.Task8(x, y, corners);
            Assert.That(actual.Item1, Is.EqualTo(expectedX).Within(1.5).Percent);
            Assert.That(actual.Item2, Is.EqualTo(expectedY).Within(1.5).Percent);
        }
    }
}