using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    public abstract class Bird
    {
        public float Rotation
        {
            get 
            {
                return (float)Math.Atan2(this.Velocity.Vy, this.Velocity.Vx); 
            }
        }

        public Vector2 Position{get; protected set;}

        public Vector2 Velocity{get; protected set;}

        public World world;

        protected Vector2 amountToSteer;

        //parameter-less constructor to random posstion and velocity
        public Bird(){
            Random ran = new Random();
            world = new World();
            this.Position = new Vector2(ran.Next(world.Height), ran.Next(world.Width));
            this.Velocity = new Vector2(ran.Next(-4, 5), ran.Next(-4, 5));
            this.amountToSteer = new Vector2(0,0);

        }

        //parameterize constructor for testing
        public Bird(int posVx, int posVy, int velVx, int velVy){
            this.Position = new Vector2(posVx, posVy);
            this.Velocity = new Vector2(velVx, velVy);
            this.amountToSteer = new Vector2(0,0);
        }

        //TODO: Add the constructor, properties and fields as specified in the instructions document.

        ///<value> Property <c>Rotation</c> to rotate the raven to face the direction it is moving toward.</value>

        ///<summary>
        ///This method is a private helper method to make bird objects reappear on the opposite edge if they go outside the bounds of the screen
        ///</summary>
       public void AppearOnOppositeSide()
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

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector using the flocking algorithm rules
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
       public abstract void CalculateBehaviour(List<Sparrow> sparrows);

        ///<summary>
        ///This method is an event handler that updates the velocity and position of a bird object.
        ///</summary>
       public virtual void Move(){
           this.Velocity += this.amountToSteer;
           this.Position += this.Velocity;
           AppearOnOppositeSide();
       }
    }
}