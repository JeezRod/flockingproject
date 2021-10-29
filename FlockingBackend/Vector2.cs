using System;

namespace FlockingBackend
{
    public struct Vector2
    {
        private float vx;
        private float vy;

        public Vector2(float vx, float vy){
            this.vx = vx;
            this.vy = vy;
        }

        public float Vx{
            get{ return vx;}
        }
        public float Vy{
            get{ return vy;}
        }

        /*
        *   Overloading the sum operator to sum vectors.
        */
        public static Vector2 operator +(Vector2 u, Vector2 v){
            return new Vector2(u.vx + v.vx, u.vy + v.vy);
        }

        /*
        *   Overloading the minus operator to substract vectors.
        */
        public static Vector2 operator -(Vector2 u, Vector2 v){
            return new Vector2(u.vx - v.vx, u.vy - v.vy);
        }

        /*
        *   Overloading the dividend operator to divide vectors by a scalar.
        */
        public static Vector2 operator /(Vector2 u, float c){
            return new Vector2(u.vx/c, u.vy/c);
        }

        /*
        *   Overloading the product operator to multiply a vector and scalar.
        */

        public static Vector2 operator *(Vector2 u, float c){
            return new Vector2(u.vx * c, u.vy * c);
        }

        /*
        *   This method takes two vectors and calculates the square root of the distance.
        */
        public static float DistanceSquared(Vector2 u, Vector2 v){
            return (float)Math.Sqrt(Math.Pow((u.vx - v.vx), 2) + Math.Pow((u.vy - v.vy), 2));
        }

        /*
        *   This method Normalizes a vector and returns a new Vector.
        */
        public static Vector2 NormalizeVector(Vector2 u){
            float magnitud = (float)Math.Sqrt((u.vx*u.vx) + (u.vy*u.vy));
            return new Vector2(u.vx/magnitud, u.vy/magnitud);
        }

        public override string ToString()
        {
            return vx +", "+ vy;
        }

    }
}
