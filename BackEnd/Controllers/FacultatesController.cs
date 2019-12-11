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
    public class FacultatesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FacultatesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Facultates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facultate>>> GetFacultate()
        {
            return await _context.Facultate.ToListAsync();
        }

        // GET: api/Facultates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Facultate>> GetFacultate(int id)
        {
            var facultate = await _context.Facultate.FindAsync(id);

            if (facultate == null)
            {
                return NotFound();
            }

            return facultate;
        }

        // PUT: api/Facultates/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacultate(int id, Facultate facultate)
        {
            if (id != facultate.Id)
            {
                return BadRequest();
            }

            _context.Entry(facultate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultateExists(id))
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

        // POST: api/Facultates
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Facultate>> PostFacultate(Facultate facultate)
        {
            _context.Facultate.Add(facultate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacultate", new { id = facultate.Id }, facultate);
        }

        // DELETE: api/Facultates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Facultate>> DeleteFacultate(int id)
        {
            var facultate = await _context.Facultate.FindAsync(id);
            if (facultate == null)
            {
                return NotFound();
            }

            _context.Facultate.Remove(facultate);
            await _context.SaveChangesAsync();

            return facultate;
        }

        private bool FacultateExists(int id)
        {
            return _context.Facultate.Any(e => e.Id == id);
        }
    }
}
