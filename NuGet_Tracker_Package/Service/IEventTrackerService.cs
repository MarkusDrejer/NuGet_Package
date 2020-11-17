using Models;

namespace NuGet_Tracker_Package.Service
{
    public interface IEventTrackerService
    {
        void TrackEvent(BaseEvent baseEvent);
    }
}
