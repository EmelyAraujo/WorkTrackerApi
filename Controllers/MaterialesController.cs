using System;
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
    public class MaterialesController : ControllerBase
    {
        private readonly Contexto _context;

        public MaterialesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Materiales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materiales>>> Getmateriales()
        {
          if (_context.materiales == null)
          {
              return NotFound();
          }
            return await _context.materiales.ToListAsync();
        }

        // GET: api/Materiales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materiales>> GetMateriales(int id)
        {
          if (_context.materiales == null)
          {
              return NotFound();
          }
            var materiales = await _context.materiales.FindAsync(id);

            if (materiales == null)
            {
                return NotFound();
            }

            return materiales;
        }

        // PUT: api/Materiales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateriales(int id, Materiales materiales)
        {
            if (id != materiales.ObraId)
            {
                return BadRequest();
            }

            _context.Entry(materiales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialesExists(id))
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

        // POST: api/Materiales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Materiales>> PostMateriales(Materiales materiales)
        {
          if (_context.materiales == null)
          {
              return Problem("Entity set 'Contexto.materiales'  is null.");
          }
            _context.materiales.Add(materiales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMateriales", new { id = materiales.ObraId }, materiales);
        }

        // DELETE: api/Materiales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateriales(int id)
        {
            if (_context.materiales == null)
            {
                return NotFound();
            }
            var materiales = await _context.materiales.FindAsync(id);
            if (materiales == null)
            {
                return NotFound();
            }

            _context.materiales.Remove(materiales);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MaterialesExists(int id)
        {
            return (_context.materiales?.Any(e => e.ObraId == id)).GetValueOrDefault();
        }
    }
}
