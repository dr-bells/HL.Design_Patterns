using System;
using Design_Patterns.Door;

namespace Design_Patterns.DoorMaker
{
    public abstract class Door : IDoor
    {
        protected string _description = "No Description";
        public abstract string Description { get; }
        public abstract int Cost();
        public abstract void GetDescription();
    }
}