using Design_Patterns.Doors;

namespace Design_Patterns.DoorMakers
{
    public abstract class Door : IDoor
    {
        protected string _description = "No Description";
        public abstract string Description { get; }
        public abstract int Cost();
        public abstract void GetDescription();
    }
}