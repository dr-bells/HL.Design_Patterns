using System;
using Design_Patterns.DoorMakers;
using Design_Patterns.DoorMakers.WoodenDoors;

namespace Design_Patterns.DoorTypes
{
    class DoubleWroughtIronDoor : WroughtDecorator
    {
        Door _door;
        public DoubleWroughtIronDoor(Door door)
        {
            this._door = door;
        }

        public override string Description
        {
            get
            {
                if (_door.Description.StartsWith("Double"))
                {
                    return "Double " + _door.Description;
                }
                else
                    return "French " + _door.Description;
            }
        }

        public override int Cost()
        {
            return 50 + _door.Cost();
        }

        public override void GetDescription()
        {
            Console.WriteLine("This is a Decorated Double Iron door.");

        }
    }
}