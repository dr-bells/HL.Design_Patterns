using Design_Patterns.Door;
using Design_Patterns.DoorFitter;
using Design_Patterns.DoorMaker.WoodenDoors;
using Design_Patterns.DoorMaker;

namespace Design_Patterns.DoorFactory
{
    public class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoor MakeDoor(string type)
        {
            return new WoodenDoor(type);
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }
}