using System;
using Design_Patterns.DoorFactory;
using Design_Patterns.DoorMaker.WoodenDoors;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodenDoorFactory = new WoodenDoorFactory();

            var woodenDoor = woodenDoorFactory.MakeDoor();
            var woodenDoorFittingExpert = woodenDoorFactory.MakeFittingExpert();
            var battenedWoodenDoor = new BattenedWoodenDoor();

            battenedWoodenDoor.GetDescription();
            woodenDoor.GetDescription();
            woodenDoorFittingExpert.GetDescription();

            var ironDoorFactory = new IronDoorFactory();

            var ironDoor = ironDoorFactory.MakeDoor();
            var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

            ironDoor.GetDescription();
            ironDoorFittingExpert.GetDescription();
        }
    }
}
