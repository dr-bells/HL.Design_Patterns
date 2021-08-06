using System;

namespace Design_Patterns.DoorMakers.WoodenDoors
{
    class FrenchBattenedDoor : BattenedDecorator
    {
        Door _door;
        public FrenchBattenedDoor(Door door)
        {
            this._door = door;
        }

        public override string Description
        {
            get
            {
                if (_door.Description.StartsWith("French"))
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
            Console.WriteLine("This is a French Decorated Battened Wooden door.");

        }
    }
}