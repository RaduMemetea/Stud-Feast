using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd;
using DataModels.Models;
using DataModels.Translates;

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
        public async Task<ActionResult<IEnumerable<OrarResponse>>> GetOrar()
        {
            List<OrarResponse> v = new List<OrarResponse>();
            foreach (var item in await _context.Orar.AsNoTracking().ToListAsync())
                v.Add(new OrarResponse
                {
                    Id = item.Id,
                    An = item.An,
                    Grupa = item.Grupa,
                    Subgrupa = item.Subgrupa,

                    Curs = item.Curs,
                    Ora = item.Ora,
                    Par_Impar = item.Par_Impar,

                    MaterieId =item.MaterieId, 
                    Materie= await _context.Materie.FindAsync(item.MaterieId),
                    ProfesorId =item.ProfesorId,
                    Profesor= await _context.Profesori.FindAsync(item.ProfesorId),
                    SalaId =item.SalaId,
                    Sala= await _context.Sala.FindAsync(item.SalaId),
                    SpecializareId = item.SpecializareId,
                    Specializare = await _context.Specializare.FindAsync(item.SpecializareId),
                    FacultateId = item.FacultateId,
                    Facultate = await _context.Facultate.FindAsync(item.FacultateId)

                });


            return v;
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

            return new OrarResponse
            {
                Id = orar.Id,
                An = orar.An,
                Grupa = orar.Grupa,
                Subgrupa = orar.Subgrupa,

                Curs = orar.Curs,
                Ora = orar.Ora,
                Par_Impar = orar.Par_Impar,

                MaterieId = orar.MaterieId,
                Materie = await _context.Materie.FindAsync(orar.MaterieId),
                ProfesorId = orar.ProfesorId,
                Profesor = await _context.Profesori.FindAsync(orar.ProfesorId),
                SalaId = orar.SalaId,
                Sala = await _context.Sala.FindAsync(orar.SalaId),
                SpecializareId = orar.SpecializareId,
                Specializare = await _context.Specializare.FindAsync(orar.SpecializareId),
                FacultateId = orar.FacultateId,
                Facultate = await _context.Facultate.FindAsync(orar.FacultateId)

            };
        }

        // PUT: api/Orars/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrar(int id, OrarT orar)
        {
            if (id != orar.Id)
            {
                return BadRequest();
            }
            Orar ne = new Orar
            {
                An = orar.An,
                Curs = orar.Curs,
                FacultateId = orar.FacultateId,
                Grupa = orar.Grupa,
                Id = orar.Id,
                MaterieId = orar.MaterieId,
                Par_Impar = orar.Par_Impar,
                ProfesorId = orar.ProfesorId,
                SalaId = orar.SalaId,
                SpecializareId = orar.SpecializareId,
                Subgrupa = orar.Subgrupa,
                Ora = DateTimeOffset.Parse(orar.Ora)
            };
            _context.Entry(ne).State = EntityState.Modified;

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
        public async Task<ActionResult<Orar>> PostOrar(OrarT orar)
        {
            Orar ne = new Orar { An = orar.An ,
                Curs =orar.Curs, 
                FacultateId=orar.FacultateId, 
                Grupa=orar.Grupa, 
                Id=orar.Id, 
                MaterieId=orar.MaterieId, 
                Par_Impar=orar.Par_Impar, 
                ProfesorId=orar.ProfesorId, 
                SalaId=orar.SalaId, 
                SpecializareId=orar.SpecializareId, 
                Subgrupa=orar.Subgrupa, 
                Ora=DateTimeOffset.Parse(orar.Ora)
                };

            Console.WriteLine();
            _context.Orar.Add(ne);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrar", new { id = ne.Id }, orar);
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
