using System;

namespace Design_Patterns.DoorMakers.WoodenDoors
{
    class BattenedWoodenDoor : Door
    {
        public BattenedWoodenDoor()
        {
            _description = "Battened door";
        }

        public override string Description => _description;

        public override int Cost()
        {
            return 50;
        }

        public override void GetDescription()
        {
            Console.WriteLine("This is a standard Battened Wooden door.");

        }
    }
}