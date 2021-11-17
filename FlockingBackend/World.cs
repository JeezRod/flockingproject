using System;
using System.Collections.Generic;


namespace FlockingBackend
{
    public class World
    {
        public Flock _flock;
        public Raven _raven;
        public List<Sparrow> _sparrows = new List<Sparrow>();
        public static int InitialCount {get;}
        public static int Width {get;}
        public static int Height {get;}
        public static int MaxSpeed {get;}
        public static int NeighbourRadius {get;}        
        public static int AvoidanceRadius {get;}

        ///<summary>
        //Static constructor with static world's field
        ///</summary>
        static World(){
            InitialCount = 150;
            Width = 1000;
            Height = 500;
            MaxSpeed = 4;
            NeighbourRadius = 100;
            AvoidanceRadius = 50;
        }

        ///<summary>
        //A constructor that takes no inputs and initializes the Flock object and List<Sparrow>
        ///</summary>
        public World(){
            _flock = new Flock();
            _sparrows = PopulateSparrow();
            _raven = new Raven();
            // Subscribing the raven
            _flock.Subscribe(_raven.CalculateBehaviour, _raven.Move);
        }

        ///<summary>
        //Populate List<Sparrow>
        ///</summary>
        private List<Sparrow> PopulateSparrow(){
            List<Sparrow> newList = new List<Sparrow>();
            for(int i=0; i<InitialCount; i++){
                Sparrow s = new Sparrow();
                //Subscribe the Sparrow
                _flock.Subscribe(s.CalculateBehaviour, s.Move, s.CalculateRavenAvoidance);
                newList.Add(s);
            }
            return newList;
        }

        ///<summary>
        //Invoke RaiseMoveEvents method
        ///</summary>
        public void Update(){
            _flock.RaiseMoveEvents(_sparrows, _raven);
        }
    }
}
