using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTest.ShapeHelper;

namespace ShapeTest.Tests
{
    [TestClass]
    public class TriangleTest
    {

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void SideIsZero()
        {
            Triangle _ = new(6.0, 0.0, 4.0);
        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void SideIsLessThanZero()
        {
            Triangle _ = new(6.0, 10.0, -4.0);
        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void TriangleNotExist()
        {
            Triangle _ = new(25, 10, 5);
        }

        [TestMethod]
        public void TriangleAreaDeltaCompute()
        {
            Triangle trg = new(40, 35, 25);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(433.0127018922, trg.GetArea, 1E-6, "Result out of range!");
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle trg = new(17, 144, 145);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(trg.IsRight());
        }

        [TestMethod]
        public void TriangleIsNotRight()
        {
            Triangle trg = new(17, 144, 145.04);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsFalse(trg.IsRight());
        }
    }
}
