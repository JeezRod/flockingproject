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
        public float Rotation
        {
            get 
            {
                return (float)Math.Atan2(this.Velocity.Vy, this.Velocity.Vx); 
            }
        }

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
<<<<<<< HEAD
        private Vector2 ChaseSparrow (List<Sparrow> sparrows){

        }
=======
        // private Vector2 ChaseSparrow (List<Sparrow> sparrows);
        
       
       ///<summary>
        ///This method is a private helper method to make sparrows reappear on the opposite edge if they go outside the bounds of the screen
        ///</summary>
       private void AppearOnOppositeSide()
       {
           if (this.Position.Vx > world.Width)
            {
                this.Position = new Vector2(0, this.Position.Vy);
            }
            else if(this.Position.Vx < 0)
            {
                 this.Position = new Vector2(world.Width, this.Position.Vy);
            }
            if (this.Position.Vy > world.Height)
            {
                this.Position = new Vector2(this.Position.Vx, 0);
            }
            else if(this.Position.Vy < 0)
            {
                this.Position= new Vector2(this.Position.Vx, world.Height);
            }
       }
>>>>>>> 6ceff3133e916dbe0d632264715de1e2e9081b47
    }
}