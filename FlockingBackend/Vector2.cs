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
    }
}
