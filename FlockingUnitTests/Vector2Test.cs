using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System;

namespace FlockingUnitTests
{
    [TestClass]
    public class Vector2Test
    {
        [TestMethod]
        public void Vector2SumTest()
        {
            Vector2 result = new Vector2(305.0E-2f, 205.0E-2f);
            Vector2 v1 = new Vector2(200.0E-2f, 100.0E-2f);
            Vector2 v2 = new Vector2(105.0E-2f, 105.0E-2f);

            Assert.AreEqual(result,v1+v2);
        }

        [TestMethod]
        public void Vector2SubstractionTest()
        {
            Vector2 result = new Vector2(-100.0E-2f, 050.0E-2f);
            Vector2 v1 = new Vector2(200.0E-2f, 150.0E-2f);
            Vector2 v2 = new Vector2(300.0E-2f, 100.0E-2f);

            Assert.AreEqual(result,v1-v2);
        }

        [TestMethod]
        public void Vector2DividendTest()
        {
            Vector2 result = new Vector2(100.0E-2f, 150.0E-2f);
            Vector2 v1 = new Vector2(200.0E-2f, 300.0E-2f);
            float c = 200.0E-2f;

            Assert.AreEqual(result, v1/c);
        }

        [TestMethod]
        public void Vector2MultiplyScalarTest()
        {
            Vector2 result = new Vector2(400.0E-2f, 600.0E-2f);
            Vector2 v1 = new Vector2(200.0E-2f, 300.0E-2f);
            float c = 200.0E-2f;

            Assert.AreEqual(result, v1*c);
        }

        [TestMethod]
        public void Vector2DistanceSquaredTest()
        {
            float result = 2236068.0E-6f;
            Vector2 v1 = new Vector2(200.0E-2f, 300.0E-2f);
            Vector2 v2 = new Vector2(100.0E-2f, 100.0E-2f);

            Assert.AreEqual(result, Vector2.DistanceSquared(v1,v2));
        }

        [TestMethod]
        public void Vector2NormalizeVectorTest()
        {
            Vector2 result = new Vector2(0554700196.0E-9f, 0832050300.0E-9f);
            Vector2 v1 = new Vector2(200.0E-2f, 300.0E-2f);
            
            Assert.AreEqual(result, Vector2.NormalizeVector(v1));
        }

    }
}
