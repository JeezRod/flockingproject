using System;
using System.Collections.Generic;

namespace FlockingBackend{
    ///<summary>
    ///This class is used to represent a single raven. 
    ///This class is just a starting point. Complete the TODO sections
    ///</summary>
    public class Raven : Bird
    {
        ///<summary>
        //Invoke Bird parameter-less constructor
        ///</summary>
        public Raven(): base(){}

        ///<summary>
        //Invoke Bird constructor with parameters
        ///</summary>
        ///<param name="posVx">factor X of Position Vector2 object</param>
        ///<param name="posVy">factor Y of Position Vector2 object</param>
        ///<param name="velVx">factor X of Velocity Vector2 object</param>
        ///<param name="velVx">factor Y of Velocity Vector2 object</param>

        public Raven(int posVx, int posVy, int velVx, int velVy): base(posVx, posVy, velVx, velVy){}


        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            this.amountToSteer = ChaseSparrow(sparrows);
        }

        
        ///<summary>
        ///This method is an event handler that updates the velocity and position of a bird object.
        ///</summary>
        public override void Move(){
           
           this.Velocity += this.amountToSteer;
           this.Velocity = Vector2.NormalizeVector(this.Velocity) * World.MaxSpeed;
           this.Position += this.Velocity;
           AppearOnOppositeSide();
        }
       
        ///<summary>
        //ChaseSparrow algorithm is to make the Raven chase the closest Sparrow 
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public Vector2 ChaseSparrow(List<Sparrow> sparrows){
            float distance;
            float avoidanceSquareRadius = (float)Math.Pow(World.AvoidanceRadius,2);
            float nearestDistance = avoidanceSquareRadius;
            Sparrow nearSparrow = null;
            Vector2 result = new Vector2(0,0);

            foreach(Sparrow sp in sparrows){
                distance = Vector2.DistanceSquared(this.Position, sp.Position);
                
                if(distance < avoidanceSquareRadius && distance < nearestDistance){
                    // set the sparrow as the nearest to raven
                    nearSparrow = sp;
                    nearestDistance = distance;
                }
            }

            if(nearSparrow != null){
                return Vector2.NormalizeVector(nearSparrow.Position - this.Position);
            }

            return result;
        }
    }
}