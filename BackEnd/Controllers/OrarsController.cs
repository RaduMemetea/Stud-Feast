using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd;
using DataModels.Models;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrarsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrarsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Orars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orar>>> GetOrar()
        {
            return await _context.Orar.ToListAsync();
        }

        // GET: api/Orars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orar>> GetOrar(int id)
        {
            var orar = await _context.Orar.FindAsync(id);

            if (orar == null)
            {
                return NotFound();
            }

            return orar;
        }

        // PUT: api/Orars/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrar(int id, Orar orar)
        {
            if (id != orar.Id)
            {
                return BadRequest();
            }

            _context.Entry(orar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrarExists(id))
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

        // POST: api/Orars
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Orar>> PostOrar(Orar orar)
        {
            _context.Orar.Add(orar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrar", new { id = orar.Id }, orar);
        }

        // DELETE: api/Orars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Orar>> DeleteOrar(int id)
        {
            var orar = await _context.Orar.FindAsync(id);
            if (orar == null)
            {
                return NotFound();
            }

            _context.Orar.Remove(orar);
            await _context.SaveChangesAsync();

            return orar;
        }

        private bool OrarExists(int id)
        {
            return _context.Orar.Any(e => e.Id == id);
        }
    }
}
