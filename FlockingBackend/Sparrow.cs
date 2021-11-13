using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single sparrow. 
    ///This class is just a starting point. Complete the TODO sections
    ///</summary>
    public class Sparrow: Bird
    { 
        public Sparrow(): base(){
            
        }

        public Sparrow(int posVx, int posVy, int velVx, int velVy): base(posVx, posVy, velVx, velVy){

        }

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector using the flocking algorithm rules
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            //TODO: Set the amountToSteer vector with the vectors returned by 
            //Cohesion, Alignment, Avoidance methods
            
            this.amountToSteer = Alignment(sparrows) + Cohesion(sparrows) + Avoidance(sparrows);
        }
        ///<summary>
        ///This method is an event handler to calculate and update amountToSteer vector with the amount to steer to flee a chasing raven
        ///</summary>
        ///<param name="raven">A Raven object</param>
        public void CalculateRavenAvoidance(Raven raven)
        {
             //TODO: Add the vector returned by FleeRaven to the amountToSteer vector.
             this.amountToSteer += FleeRaven(raven);
             
        }

        //TODO: Code the following private helper methods to implement the flocking algorithm rules. 
        //The method headers are declared below:
        private Vector2 Alignment (List<Sparrow> sparrows){
            float distance;
            int countSp = 0;
            Vector2 result = new Vector2(0,0);
            foreach(Sparrow sp in sparrows){
                distance =Vector2.DistanceSquared(this.Position, sp.Position);
                if(distance < World._neighbourRadius && sp != this){
                    result += sp.Velocity;
                    countSp ++;
                }
            }
            if(countSp != 0 ){
                result = result/countSp;
                result = Vector2.NormalizeVector(result);
                result = result * World._maxSpeed;
                result = result - this.Velocity;
                result = Vector2.NormalizeVector(result);
            }
            return result;
        }
        
        private Vector2 Cohesion (List<Sparrow> sparrows){
            float distance;
            int countSp = 0;
            Vector2 result = new Vector2(0,0);
            foreach(Sparrow sp in sparrows){
                distance =Vector2.DistanceSquared(this.Position, sp.Position);
                if(distance < World._neighbourRadius && sp != this){
                    result += sp.Position;
                    countSp ++;
                }
            }
            if(countSp != 0){
                //average 
                result = result/countSp;
                //Normalize vector
                result = Vector2.NormalizeVector(result);
                // result is average position
                result = result - this.Position;
                result = Vector2.NormalizeVector(result);

                result = result * World._maxSpeed;

                result = result - this.Velocity;
                result = Vector2.NormalizeVector(result);  
            }
            return result;
        }
        private Vector2 Avoidance (List<Sparrow> sparrows){
            float distance;
            int countSp = 0;
            Vector2 result = new Vector2(0,0);
            foreach(Sparrow sp in sparrows){
                distance = Vector2.DistanceSquared(this.Position, sp.Position);
                if(distance < World._avoidanceRadius && sp != this){
                    result = this.Position - sp.Position;
                    result += result / distance;
                    countSp++;
                }
            }
            if(countSp != 0){
                result = result / countSp;
                result = result - this.Velocity;
                result = Vector2.NormalizeVector(result);
            }
            return result;
        }
        private Vector2 FleeRaven(Raven raven){
            Vector2 result = new Vector2(0,0);
            float distance = Vector2.DistanceSquared(this.Position, raven.Position);
            if(distance < World._avoidanceRadius){
                result = this.Position - raven.Position;
                result = result/distance;
                result = Vector2.NormalizeVector(result);
                result = result * World._maxSpeed;
            }
            return result;
        }

    }
}