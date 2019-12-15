using DataModels.Models;
using DataModels.Translates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializaresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SpecializaresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Specializares
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecializareResponse>>> GetSpecializare()
        {
            List<SpecializareResponse> v = new List<SpecializareResponse>();
            foreach (var item in await _context.Specializare.AsNoTracking().ToListAsync())
                v.Add(new SpecializareResponse
                {
                    Id = item.Id,
                    An = item.An,
                    Nume = item.Nume,
                    FacultateId = item.FacultateId,
                    Facultate = await _context.Facultate.FindAsync(item.FacultateId)
                });


            return v;

        }

        // GET: api/Specializares/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpecializareResponse>> GetSpecializare(int id)
        {
            var specializare = await _context.Specializare.FindAsync(id);

            if (specializare == null)
            {
                return NotFound();
            }

            return new SpecializareResponse
            {
                Id = specializare.Id,
                An = specializare.An,
                Nume = specializare.Nume,
                FacultateId = specializare.FacultateId,
                Facultate = await _context.Facultate.FindAsync(specializare.FacultateId)
            };
        }

        // PUT: api/Specializares/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecializare(int id, Specializare specializare)
        {
            if (id != specializare.Id)
            {
                return BadRequest();
            }

            _context.Entry(specializare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecializareExists(id))
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

        // POST: api/Specializares
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Specializare>> PostSpecializare(Specializare specializare)
        {
            _context.Specializare.Add(specializare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpecializare", new { id = specializare.Id }, specializare);
        }

        // DELETE: api/Specializares/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Specializare>> DeleteSpecializare(int id)
        {
            var specializare = await _context.Specializare.FindAsync(id);
            if (specializare == null)
            {
                return NotFound();
            }

            _context.Specializare.Remove(specializare);
            await _context.SaveChangesAsync();

            return specializare;
        }

        private bool SpecializareExists(int id)
        {
            return _context.Specializare.Any(e => e.Id == id);
        }
    }
}
