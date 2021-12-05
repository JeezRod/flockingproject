using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    public class Flock
    {
        private event Delegates.CalculateMoveVector calcMovementEvent;
        private event Delegates.CalculateRavenAvoidance calcRavenFleeEvent;
        private event Delegates.MoveBird moveEvent;

        ///<summary>
        //Subscribe method that takes as input a CalculateMoveVector delegate instance, 
        //a MoveBird delegate instance and an optional CalculateRavenAvoidance delegate instance and
        //subscribes them to the corresponding events
        ///</summary>
        ///<param name="calculateMoveVecor">A delegate</param>
        ///<param name="moveBird">A delegate</param>
        ///<param name="calRavenAv">A delegate</param>
        public void Subscribe(Delegates.CalculateMoveVector calculateMoveVector, Delegates.MoveBird moveBird, Delegates.CalculateRavenAvoidance calRavenAv = default){
            
            calcMovementEvent += calculateMoveVector;
            moveEvent += moveBird;
            calcRavenFleeEvent += calRavenAv;

        }

        ///<summary>
        ///This method raises the calculate and move events
        ///</summary>
        ///<param name="sparrows">List of Sparrow objects</param>
        ///<param name="raven">A Raven object</param>
        public void RaiseMoveEvents(List<Sparrow> sparrows, Raven raven)
        {
            calcMovementEvent?.Invoke(sparrows);
            calcRavenFleeEvent?.Invoke(raven);
            moveEvent?.Invoke();
        }

        
    }
}