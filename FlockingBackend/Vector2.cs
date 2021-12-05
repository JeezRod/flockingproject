using System;

namespace FlockingBackend
{
    public struct Vector2
    {
        private float vx;
        private float vy;

        ///<summary>
        //Parameter constructor to initialize factor X and Y of Vector2 object
        ///</summary>
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

        ///<summary>
        //Overloading the sum operator to sum vectors.
        ///<summary>
        public static Vector2 operator +(Vector2 u, Vector2 v){
            return new Vector2(u.vx + v.vx, u.vy + v.vy);
        }

        ///<summary>
        //Overloading the minus operator to substract vectors.
        ///<summary>
        public static Vector2 operator -(Vector2 u, Vector2 v){
            return new Vector2(u.vx - v.vx, u.vy - v.vy);
        }

        ///<summary>
        //Overloading the dividend operator to divide vectors by a scalar.
        ///</summary>
        public static Vector2 operator /(Vector2 u, float c){
            return new Vector2(u.vx/c, u.vy/c);
        }

        ///<summary>
        //Overloading the product operator to multiply a vector and scalar.
        ///</summary>

        public static Vector2 operator *(Vector2 u, float c){
            return new Vector2(u.vx * c, u.vy * c);
        }

        ///<summary>
        //This method takes two vectors and calculates the square root of the distance.
        ///</summary>
        public static float DistanceSquared(Vector2 u, Vector2 v){
            return (float)(Math.Pow((u.vx - v.vx), 2) + Math.Pow((u.vy - v.vy), 2));
        }

        ///<summary>
        //This method Normalizes a vector and returns a new Vector.
        ///<summary>
        public static Vector2 NormalizeVector(Vector2 u){
            float magnitud = (float)Math.Sqrt((u.vx*u.vx) + (u.vy*u.vy));
            if(magnitud != 0){
                return new Vector2(u.vx / magnitud, u.vy / magnitud);
            }
            return new Vector2(0,0);
        }

        public override string ToString()
        {
            return vx +", "+ vy;
        }

    }
}
