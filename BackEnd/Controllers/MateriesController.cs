using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataModels;
using DataModels.Models;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MateriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Materies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materie>>> GetMaterie()
        {
            return await _context.Materie.ToListAsync();
        }

        // GET: api/Materies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Materie>> GetMaterie(int id)
        {
            var materie = await _context.Materie.FindAsync(id);

            if (materie == null)
            {
                return NotFound();
            }

            return materie;
        }

        // PUT: api/Materies/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterie(int id, Materie materie)
        {
            if (id != materie.Id)
            {
                return BadRequest();
            }

            _context.Entry(materie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterieExists(id))
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

        // POST: api/Materies
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Materie>> PostMaterie(Materie materie)
        {
            _context.Materie.Add(materie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterie", new { id = materie.Id }, materie);
        }

        // DELETE: api/Materies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Materie>> DeleteMaterie(int id)
        {
            var materie = await _context.Materie.FindAsync(id);
            if (materie == null)
            {
                return NotFound();
            }

            _context.Materie.Remove(materie);
            await _context.SaveChangesAsync();

            return materie;
        }

        private bool MaterieExists(int id)
        {
            return _context.Materie.Any(e => e.Id == id);
        }
    }
}
