using System;

namespace Design_Patterns.DoorMakers
{
    public class WoodDoorMaker : DoorMakingProcess
    {
        public void MakeDoor()
        {
            Console.WriteLine("We are in the process of making a wooden door now........");
        }
    }
}