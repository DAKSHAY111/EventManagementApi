using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagementApi.Models;

namespace EventManagementApi.Data
{
    public class EventManagementApiContext : DbContext
    {
        public EventManagementApiContext (DbContextOptions<EventManagementApiContext> options)
            : base(options)
        {
        }

        public DbSet<EventManagementApi.Models.Event> Event { get; set; } = default!;

        public DbSet<EventManagementApi.Models.User> User { get; set; }

        public DbSet<EventManagementApi.Models.ParticipantEvent>? ParticipantEvent { get; set; }
    }
}
