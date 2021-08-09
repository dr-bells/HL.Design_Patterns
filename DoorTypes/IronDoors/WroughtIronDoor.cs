using System;

namespace Design_Patterns.DoorMakers.WoodenDoors
{
    class WroughtIronDoor : Door
    {
        public WroughtIronDoor()
        {
            _description = "Wrought door";
        }

        public override string Description => _description;

        public override int Cost()
        {
            return 50;
        }

        public override void GetDescription()
        {
            Console.WriteLine("This is a standard Wrought Iron door.");
        }
    }
}