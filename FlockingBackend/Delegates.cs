using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    public delegate void CalculateMoveVector(List<Sparrow> sp);

    public delegate void MoveBird();

    public delegate void CalculateRavenAvoidance(Raven rv);
}
