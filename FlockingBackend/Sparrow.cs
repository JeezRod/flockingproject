using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single sparrow. 
    ///This class is just a starting point. Complete the TODO sections
    ///</summary>
<<<<<<< HEAD
    public class Sparrow: Bird
    { 
        public Sparrow(): base(){
            
=======
    public class Sparrow : Bird
    {
        //TODO: Add the constructor, properties and fields as specified in the instructions document.

        ///<value> Property <c>Rotation</c> to rotate the Sparrow to face the direction it is moving toward.</value>
        public float Rotation
        {
            get 
            {
                return (float)Math.Atan2(this.velocity.Y, this.velocity.X); 
            }
>>>>>>> 42a2b46db08f525094cda970509dd36014484123
        }

        public Sparrow(int posVx, int posVy, int velVx, int velVy): base(posVx, posVy, velVx, velVy){

        }

         //TODO: Add the constructor, properties and fields as specified in the instructions document.

        ///<value> Property <c>Rotation</c> to rotate the Sparrow to face the direction it is moving toward.</value>

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector using the flocking algorithm rules
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            //TODO: Set the amountToSteer vector with the vectors returned by 
            //Cohesion, Alignment, Avoidance methods
        }
        ///<summary>
        ///This method is an event handler to calculate and update amountToSteer vector with the amount to steer to flee a chasing raven
        ///</summary>
        ///<param name="raven">A Raven object</param>
        public void CalculateRavenAvoidance(Raven raven)
        {
             //TODO: Add the vector returned by FleeRaven to the amountToSteer vector.
        }

        //TODO: Code the following private helper methods to implement the flocking algorithm rules. 
        //The method headers are declared below:
        private Vector2 Alignment (List<Sparrow> sparrows){

        }
        private Vector2 Cohesion (List<Sparrow> sparrows){

        }
        private Vector2 Avoidance (List<Sparrow> sparrows){

        }
        private Vector2 FleeRaven(Raven raven){

        }
        
       
        
    }
}