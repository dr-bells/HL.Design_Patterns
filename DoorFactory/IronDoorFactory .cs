using Design_Patterns.Door;
using Design_Patterns.DoorFitter;
using Design_Patterns.DoorMakers;

namespace Design_Patterns.DoorFactory
{
    public class IronDoorFactory : IDoorFactory
    {
        DoorMaker doormaker = new DoorMaker();

        public IDoor MakeDoor()
        {
            doormaker.MakeIronDoor();
            return new IronDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}