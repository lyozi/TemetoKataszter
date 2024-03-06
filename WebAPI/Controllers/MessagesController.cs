using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Infrastructure.Context;

namespace WebAPI.Controllers
{
    [Route("api/Messages")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public MessagesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Messages1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessageItems()
        {
            return await _context.MessageItems.ToListAsync();
        }

        // GET: api/Messages1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetMessage(long id)
        {
            var message = await _context.MessageItems.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            return message;
        }

        // PUT: api/Messages1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessage(long id, Message message)
        {
            if (id != message.Id)
            {
                return BadRequest();
            }

            _context.Entry(message).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageExists(id))
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

        // POST: api/Messages1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            _context.MessageItems.Add(message);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.Id }, message);
        }

        // DELETE: api/Messages1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(long id)
        {
            var message = await _context.MessageItems.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }

            _context.MessageItems.Remove(message);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessageExists(long id)
        {
            return _context.MessageItems.Any(e => e.Id == id);
        }
    }
}
