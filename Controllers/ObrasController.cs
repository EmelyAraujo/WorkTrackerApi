﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkTrackerApi.Data;
using WorkTrackerApi.Models;

namespace WorkTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObrasController : ControllerBase
    {
        private readonly Contexto _context;

        public ObrasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Obras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Obras>>> Getobras()
        {
          if (_context.obras == null)
          {
              return NotFound();
          }
            return await _context.obras.ToListAsync();
        }

        // GET: api/Obras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Obras>> GetObras(int id)
        {
          if (_context.obras == null)
          {
              return NotFound();
          }
            var obras = await _context.obras.FindAsync(id);

            if (obras == null)
            {
                return NotFound();
            }

            return obras;
        }

        // PUT: api/Obras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObras(int id, Obras obras)
        {
            if (id != obras.ObraId)
            {
                return BadRequest();
            }

            _context.Entry(obras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObrasExists(id))
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

        // POST: api/Obras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Obras>> PostObras(Obras obras)
        {
          if (_context.obras == null)
          {
              return Problem("Entity set 'Contexto.obras'  is null.");
          }
            _context.obras.Add(obras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObras", new { id = obras.ObraId }, obras);
        }

        // DELETE: api/Obras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObras(int id)
        {
            if (_context.obras == null)
            {
                return NotFound();
            }
            var obras = await _context.obras.FindAsync(id);
            if (obras == null)
            {
                return NotFound();
            }

            _context.obras.Remove(obras);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObrasExists(int id)
        {
            return (_context.obras?.Any(e => e.ObraId == id)).GetValueOrDefault();
        }
    }
}
