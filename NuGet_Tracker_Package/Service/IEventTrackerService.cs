using Models;
using System.Threading.Tasks;

namespace NuGet_Tracker_Package.Service
{
    public interface IEventTrackerService
    {
        Task TrackEventAsync(BaseEvent baseEvent);
    }
}
