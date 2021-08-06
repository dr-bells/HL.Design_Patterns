using System;
using Design_Patterns.DoorMaker.WoodenDoors;

namespace Design_Patterns.Door
{
    public class WoodenDoor : IDoor
    {
        BattenedWoodenDoor battenedWood = new BattenedWoodenDoor();

        public WoodenDoor()
        {

        }
        public WoodenDoor(string type)
        {
            Console.WriteLine("I am a decorated wooden door!");
        }
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door!");
        }
    }
}