using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataModels.Models;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfesorisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Profesoris
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesori>>> GetProfesori()
        {
            return await _context.Profesori.ToListAsync();
        }

        // GET: api/Profesoris/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesori>> GetProfesori(int id)
        {
            var profesori = await _context.Profesori.FindAsync(id);

            if (profesori == null)
            {
                return NotFound();
            }

            return profesori;
        }

        // PUT: api/Profesoris/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesori(int id, Profesori profesori)
        {
            if (id != profesori.Id)
            {
                return BadRequest();
            }

            _context.Entry(profesori).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesoriExists(id))
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

        // POST: api/Profesoris
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Profesori>> PostProfesori(Profesori profesori)
        {
            _context.Profesori.Add(profesori);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfesori", new { id = profesori.Id }, profesori);
        }

        // DELETE: api/Profesoris/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Profesori>> DeleteProfesori(int id)
        {
            var profesori = await _context.Profesori.FindAsync(id);
            if (profesori == null)
            {
                return NotFound();
            }

            _context.Profesori.Remove(profesori);
            await _context.SaveChangesAsync();

            return profesori;
        }

        private bool ProfesoriExists(int id)
        {
            return _context.Profesori.Any(e => e.Id == id);
        }
    }
}
