using System;

namespace Design_Patterns.DoorMakers
{
    public class WoodDoorMaker : DoorMakingProcess
    {
        // This is where we can put the logic of creating the door.
        //Cutting the wood, adding the nails, etc
        public void MakeDoor()
        {
            Console.WriteLine("We are in the process of making a wooden door now........");
        }
    }
}