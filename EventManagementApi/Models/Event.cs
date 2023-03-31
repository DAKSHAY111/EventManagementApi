using System.ComponentModel.DataAnnotations;

namespace EventManagementApi.Models
{
    public class Event
    {
        [Key]
        public long EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Eventlocation { get; set; } = string.Empty;
        public string EventDate { get; set; }
        public string EventDuration { get; set; } = string.Empty;
        public string EntryFees { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
