using Design_Patterns.Door;
using Design_Patterns.DoorFitter;
using Design_Patterns.DoorMakers;

namespace Design_Patterns.DoorFactory
{
    public class WoodenDoorFactory : IDoorFactory
    {
        DoorMaker doormaker = new DoorMaker();
        public IDoor MakeDoor()
        {
            doormaker.MakeWoodenDoor();
            return new WoodenDoor();
        }


        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }
}