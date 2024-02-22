using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Context;
using Domain.Models;

namespace WebAPI.Controllers
{
    [Route("api/Graves")]
    [ApiController]
    public class GravesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public GravesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Graves
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grave>>> GetGraveItems()
        {
            return await _context.GraveItems.ToListAsync();
        }

        // GET: api/Graves/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grave>> GetGrave(long id)
        {
            var grave = await _context.GraveItems.FindAsync(id);

            if (grave == null)
            {
                return NotFound();
            }

            return grave;
        }

        // PUT: api/Graves/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrave(long id, Grave grave)
        {
            if (id != grave.Id)
            {
                return BadRequest();
            }

            _context.Entry(grave).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GraveExists(id))
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

        // POST: api/Graves
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grave>> PostGrave(Grave grave)
        {
            _context.GraveItems.Add(grave);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGrave), new { id = grave.Id }, grave);
        }

        // DELETE: api/Graves/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrave(long id)
        {
            var grave = await _context.GraveItems.FindAsync(id);
            if (grave == null)
            {
                return NotFound();
            }

            _context.GraveItems.Remove(grave);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GraveExists(long id)
        {
            return _context.GraveItems.Any(e => e.Id == id);
        }
    }
}
