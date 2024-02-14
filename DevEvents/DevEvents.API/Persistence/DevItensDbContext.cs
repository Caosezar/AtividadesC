using DevEvents.API.Entities;

namespace DevEvents.API.Persistence
{
    public class DevItensDbContext
    {
        public List<DevEvent> DevEvents {get; set;}

        public DevItensDbContext()
        {
            DevEvents = new List<DevEvent>();
        }
    }
}
