using System;

namespace Design_Patterns.DoorMakers.WoodenDoors
{
    class LedgedBattenedDoor : BattenedDecorator
    {
        Door _door;
        public LedgedBattenedDoor(Door door)
        {
            this._door = door;
        }

        public override string Description
        {
            get
            {
                if (_door.Description.StartsWith("Ledged"))
                {
                    return "Double " + _door.Description;
                }
                else
                    return "Ledged " + _door.Description;
            }
        }

        public override int Cost()
        {
            return 25 + _door.Cost();
        }

        public override void GetDescription()
        {
            Console.WriteLine("This is a Ledged Decorated Battened Wooden door.");

        }
    }
}