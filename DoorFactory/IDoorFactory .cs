using Design_Patterns.Doors;
using Design_Patterns.DoorFitter;

namespace Design_Patterns.DoorFactory
{
    public interface IDoorFactory
    {
        IDoor MakeDoor();
        IDoorFittingExpert MakeFittingExpert();
    }
}