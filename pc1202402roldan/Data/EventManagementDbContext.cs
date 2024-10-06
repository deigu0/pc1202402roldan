using Microsoft.EntityFrameworkCore;
using pc1202402roldan.Models;

namespace pc1202402roldan.Data
{
    public class EventManagementDbContext : DbContext
    {
        public EventManagementDbContext(DbContextOptions<EventManagementDbContext> options) : base(options) { }

        public DbSet<Attendee> Attendees { get; set; }
        // DbSet para la tabla Organizers se generará con scaffolding
    }
}