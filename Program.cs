using System;
using Design_Patterns.DoorFactory;
using Design_Patterns.DoorMakers.WoodenDoors;

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
            var frenchDecorated = new FrenchBattenedDoor(battenedWoodenDoor);

            battenedWoodenDoor.GetDescription();
            frenchDecorated.GetDescription();
            Console.WriteLine();

            woodenDoor.GetDescription();
            woodenDoorFittingExpert.GetDescription();
            Console.WriteLine();

            var ironDoorFactory = new IronDoorFactory();

            var ironDoor = ironDoorFactory.MakeDoor();
            var ironDoorFittingExpert = ironDoorFactory.MakeFittingExpert();

            ironDoor.GetDescription();
            ironDoorFittingExpert.GetDescription();
        }
    }
}
