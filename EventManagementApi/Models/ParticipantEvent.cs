using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagementApi.Models
{
    public class ParticipantEvent
    {
        public long Id { get; set; }

        public long EventId { get; set; }

        public string Name { get; set; }  = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;
    }
}
