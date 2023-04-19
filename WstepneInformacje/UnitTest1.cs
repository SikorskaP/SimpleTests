namespace TestingMathOperations
{
    [TestClass]
    public class UnitTest1
    {
        readonly double a = 1.5756469;
        readonly double b = 2.098752345;
        double expected, actual, d, e;
        [TestMethod]
        public void TestMethod_Addition()
        {
            expected = 3.674399245;
            actual = MathOperations.Addition(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Subtraction()
        {
            expected = -0.523105445;
            actual = MathOperations.Subtraction(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Multiplication()
        {
            expected = 3.306892626266981;
            actual = MathOperations.Multiplication(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Division()
        {
            expected = 0.7507540867095493;
            actual = MathOperations.Division(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Division1()
        {
            double d = 0;
            expected = double.PositiveInfinity;
            actual = MathOperations.Division(a, d);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Division2()
        {
            d = 0; e = -10.17171;
            expected = double.NegativeInfinity;
            actual = MathOperations.Division(e, d);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Division3()
        {
            d = 0.0000000000000000000000000000000001; e = 0.000000000000000000000000002;
            expected = 0.00000005;
            actual = MathOperations.Division(d, e);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_Division4()
        {
            d = 0; e = 0;
            expected = double.NaN;
            actual = MathOperations.Division(d, e);
            Assert.AreEqual(expected, actual);
        }
    }
}