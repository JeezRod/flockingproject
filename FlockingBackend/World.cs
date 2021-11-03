using System;
using System.Collections.Generic;


namespace FlockingBackend
{
    public class World
    {
        private Flock _flock;
        private Raven _raven;
        private List<Sparrow> _sparrows;
        private static readonly int _initialCount;
        private static readonly int _width;
        private static readonly int _height;
        private static readonly int _maxSpeed;
        private static readonly int _neighbourRadius;
        private static readonly int _avoidanceRadius;

        static World(){
            _initialCount = 150;
            _width = 1000;
            _height = 500;
            _maxSpeed = 4;
            _neighbourRadius = 100;
            _avoidanceRadius = 50;
        }
        /*  A constructor that takes no inputs and initializes the Flock object and List<Sparrow>.The list should be populated with Sparrows at random positions on the screen.
            Each Sparrow in the list must also subscribe to the Flock by calling the Flock’s Subscribe method with the 3 event handler methods of the Sparrow class. See the Sparrow class section for more details on these event handler methods.
            Then, initialize the Raven object. Subscribe it to the Flock via the Flock object’s subscribe method and pass the 2 event handler methods to the subscribe method. See the Raven class section for more details on these event handler methods.
            An Update method that simply invokes the Flock’s RaiseMoveEvents method and passes the List<Sparrow> and Raven object to it.
        */

        public World(){
            _flock = new Flock();
            _sparrows = PopulateSparrow();
            _flock.RaiseMoveEvents(_sparrows, _raven);
            _raven = new Raven();
        }

        public Raven Raven{get{ return this._raven;}}

        public List<Sparrow> Sparrows{get {return this._sparrows;}}

        public int InitialCount{get{return _initialCount;}}

        public int Width{get{return _width;}}

        public int Height{get{return _height;}}

        public int MaxSpeed{get{return _maxSpeed;}}

        public int NeighbourRadius{get{return _neighbourRadius;}}

        public int AvoidanceRadius{get{return _avoidanceRadius;}}

        private List<Sparrow> PopulateSparrow(){
            List<Sparrow> newList = new List<Sparrow>();
            for(int i=0; i<_initialCount; i++){
                newList.Add(new Sparrow());
            }
            return newList;
        }
    }
}
