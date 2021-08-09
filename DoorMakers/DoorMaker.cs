namespace Design_Patterns.DoorMakers
{
    public class DoorMaker
    {
        private DoorMakingProcess _ironDoor;
        private DoorMakingProcess _woodenDoor;

        public DoorMaker()
        {
            _ironDoor = new IronDoorMaker();
            _woodenDoor = new WoodDoorMaker();
        }

        public void MakeIronDoor()
        {
            _ironDoor.MakeDoor();
        }

        public void MakeWoodenDoor()
        {
            _woodenDoor.MakeDoor();
        }
    }
}