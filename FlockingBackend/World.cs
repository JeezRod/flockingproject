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

        static World(){
            InitialCount = 150;
            Width = 1000;
            Height = 500;
            MaxSpeed = 4;
            NeighbourRadius = 100;
            AvoidanceRadius = 50;
        }
        /*  A constructor that takes no inputs and initializes the Flock object and List<Sparrow>.The list should be populated with Sparrows at random positions on the screen.
            Each Sparrow in the list must also subscribe to the Flock by calling the Flock’s Subscribe method with the 3 event handler methods of the Sparrow class. See the Sparrow class section for more details on these event handler methods.
            Then, initialize the Raven object. Subscribe it to the Flock via the Flock object’s subscribe method and pass the 2 event handler methods to the subscribe method. See the Raven class section for more details on these event handler methods.
            An Update method that simply invokes the Flock’s RaiseMoveEvents method and passes the List<Sparrow> and Raven object to it.
        */

        public World(){
            _flock = new Flock();
            _sparrows = PopulateSparrow();
            _raven = new Raven();
            // Subscribing the raven
            _flock.Subscribe(_raven.CalculateBehaviour, _raven.Move);
        }

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

        public void Update(){
            _flock.RaiseMoveEvents(_sparrows, _raven);
        }
    }
}
