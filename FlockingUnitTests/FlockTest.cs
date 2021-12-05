using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System.Collections.Generic;
using System;


namespace FlockingUnitTests
{
    [TestClass]
    public class FlockTest
    {      


        [TestMethod]
        public void ChaseSparrowTest()
        {
            Flock f = new Flock();
            Raven r = new Raven(0,0,1,1);
            List<Sparrow> sparrows = CreateSparrows();

            f.Subscribe(sparrows[0].CalculateBehaviour, sparrows[0].Move, sparrows[0].CalculateRavenAvoidance);
            f.Subscribe(sparrows[1].CalculateBehaviour, sparrows[1].Move, sparrows[1].CalculateRavenAvoidance);
            f.Subscribe(sparrows[2].CalculateBehaviour, sparrows[2].Move, sparrows[2].CalculateRavenAvoidance);

            f.RaiseMoveEvents(sparrows, r);

            Assert.AreEqual(6.057, sparrows[0].Velocity.Vx, 0.01);
            Assert.AreEqual(6.429,sparrows[0].Velocity.Vy, 0.01);
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
