using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTest.ShapeHelper;

namespace ShapeTest.Tests
{
    [TestClass]
    public class CircleTest
    {
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle _ = new(0.0);
        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle _ = new(-0.5);
        }

       [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle crc = new(5.0);
            Assert.AreEqual(78.53981633, crc.GetArea, 1E-6, "Result out of range!");
        }
    }
}
