using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pc1202402roldan.Data;
using pc1202402roldan.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace pc1202402roldan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly EventManagementDbContext _context;

        public AttendeesController(EventManagementDbContext context)
        {
            _context = context;
        }

        // GET: api/Attendees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attendee>>> GetAttendees()
        {
            return await _context.Attendees.ToListAsync();
        }

        // POST: api/Attendees
        [HttpPost]
        public async Task<ActionResult<Attendee>> PostAttendee(Attendee attendee)
        {
            _context.Attendees.Add(attendee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAttendees), new { id = attendee.Id }, attendee);
        }
    }
}
