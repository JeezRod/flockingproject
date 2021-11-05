using System;
using System.Collections.Generic;

namespace FlockingBackend{
    ///<summary>
    ///This class is used to represent a single raven. 
    ///This class is just a starting point. Complete the TODO sections
    ///</summary>
    public class Raven : Bird
    {
        //TODO: Add the constructor, properties and fields as specified in the instructions document.
        public Raven(): base(){}

        public Raven(int posVx, int posVy, int velVx, int velVy): base(posVx, posVy, velVx, velVy){}

        ///<value> Property <c>Rotation</c> to rotate the raven to face the direction it is moving toward.</value>

        ///<summary>
        ///This method is an event handler that updates the velocity and position of a raven.
        ///</summary>

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            //TODO: Set the amountToSteer vector with the vector returned by the ChaseSparrow.
        }

        //TODO: Code the following private helper methods to implement chase sparrows.
        //The method header are declared below:
        private Vector2 ChaseSparrow (List<Sparrow> sparrows){

        }
    }
}