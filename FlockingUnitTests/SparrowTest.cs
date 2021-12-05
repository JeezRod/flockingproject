using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System.Collections.Generic;
using System;

namespace FlockingUnitTests
{
    [TestClass]
    public class SparrowTest
    {      


        [TestMethod]
        public void AlignmentTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            List<Sparrow> sparrows = CreateSparrows();
            sparrows.Add(s);
            Vector2 result = s.Alignment(CreateSparrows());
            Assert.AreEqual(0.862, result.Vx, 0.01);
            Assert.AreEqual(0.506, result.Vy, 0.01);
        }

        [TestMethod]
        public void AlignmentZeroTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            List<Sparrow> sparrows = CreateSparrowsZero();
            Vector2 result = s.Alignment(sparrows);

            Assert.AreEqual(0, Math.Round(result.Vx));
            Assert.AreEqual(0, Math.Round(result.Vy));
        }

        [TestMethod]
        public void CohesionTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            List<Sparrow> sparrows = CreateSparrows();
            sparrows.Add(s);
            Vector2 result = s.Cohesion(CreateSparrows());
            Assert.AreEqual(0.157, result.Vx, 0.01);
            Assert.AreEqual(0.987,result.Vy, 0.01);
        }

        [TestMethod]
        public void CohesionZeroTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            List<Sparrow> sparrows = CreateSparrowsZero();
            Vector2 result = s.Cohesion(sparrows);

            Assert.AreEqual(0, Math.Round(result.Vx));
            Assert.AreEqual(0, Math.Round(result.Vy));
        }

        [TestMethod]
        public void AvoidanceTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            List<Sparrow> sparrows = CreateSparrows();
            sparrows.Add(s);
            Vector2 result = s.Avoidance(CreateSparrows());
            Assert.AreEqual(0.916, result.Vx, 0.01);
            Assert.AreEqual(0.399, result.Vy, 0.01);
        }

        [TestMethod]
        public void AvoidanceZeroTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            List<Sparrow> sparrows = CreateSparrowsZero();
            Vector2 result = s.Avoidance(sparrows);

            Assert.AreEqual(0, Math.Round(result.Vx));
            Assert.AreEqual(0, Math.Round(result.Vy));
        }

        [TestMethod]
        public void FleeRavenTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            Raven r = new Raven(20,30,1,1);
            Vector2 result = s.FleeRaven(r);
            Assert.AreEqual(3.577, result.Vx, 0.01);
            Assert.AreEqual(1.788, result.Vy, 0.01);
        }

        [TestMethod]
        public void FleeRavenZeroTest()
        {
            Sparrow s = new Sparrow(40, 40, 1, 1);
            Raven r = new Raven(0,0,1,1);
            Vector2 result = s.FleeRaven(r);
            Assert.AreEqual(0, result.Vx, 0.01);
            Assert.AreEqual(0, result.Vy, 0.01);
        }

        public List<Sparrow> CreateSparrowsZero(){
            List<Sparrow> listSp = new List<Sparrow>();
            listSp.Add(new Sparrow (500, 500, 1 , 3));
            listSp.Add(new Sparrow (600, 500, 2 , 3));
            listSp.Add(new Sparrow (700, 500, 1 , 3));
            return listSp;
        }


        public List<Sparrow> CreateSparrows(){
            List<Sparrow> listSp = new List<Sparrow>();
            listSp.Add(new Sparrow(15, 25, 4, 3));
            listSp.Add(new Sparrow (90, 120, 3 , 2));
            listSp.Add(new Sparrow (90, 130, 5 , 2));
            return listSp;
        }

    }
}
