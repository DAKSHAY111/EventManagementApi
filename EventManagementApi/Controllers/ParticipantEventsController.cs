using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManagementApi.Data;
using EventManagementApi.Models;

namespace EventManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantEventsController : ControllerBase
    {
        private readonly EventManagementApiContext _context;

        public ParticipantEventsController(EventManagementApiContext context)
        {
            _context = context;
        }

        // GET: api/ParticipantEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParticipantEvent>>> GetParticipantEvent()
        {
          if (_context.ParticipantEvent == null)
          {
              return NotFound();
          }
            return await _context.ParticipantEvent.ToListAsync();
        }

        // GET: api/ParticipantEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ParticipantEvent>> GetParticipantEvent(long id)
        {
          if (_context.ParticipantEvent == null)
          {
              return NotFound();
          }
            var participantEvent = await _context.ParticipantEvent.FindAsync(id);

            if (participantEvent == null)
            {
                return NotFound();
            }

            return participantEvent;
        }

        // PUT: api/ParticipantEvents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParticipantEvent(long id, ParticipantEvent participantEvent)
        {
            if (id != participantEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(participantEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParticipantEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ParticipantEvents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ParticipantEvent>> PostParticipantEvent(ParticipantEvent participantEvent)
        {
          if (_context.ParticipantEvent == null)
          {
              return Problem("Entity set 'EventManagementApiContext.ParticipantEvent'  is null.");
          }
            _context.ParticipantEvent.Add(participantEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParticipantEvent", new { id = participantEvent.Id }, participantEvent);
        }

        // DELETE: api/ParticipantEvents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParticipantEvent(long id)
        {
            if (_context.ParticipantEvent == null)
            {
                return NotFound();
            }
            var participantEvent = await _context.ParticipantEvent.FindAsync(id);
            if (participantEvent == null)
            {
                return NotFound();
            }

            _context.ParticipantEvent.Remove(participantEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParticipantEventExists(long id)
        {
            return (_context.ParticipantEvent?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
