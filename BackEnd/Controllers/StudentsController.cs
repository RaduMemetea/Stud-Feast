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
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentResponse>>> GetStudent()
        {

            List<StudentResponse> v = new List<StudentResponse>();
            foreach (var item in await _context.Student.AsNoTracking().ToListAsync())
                v.Add(new StudentResponse
                {
                    Id = item.Id,
                    Nume = item.Nume,
                    Prenume = item.Prenume,
                    Mail = item.Mail,
                    An =item.An, 
                    Grupa=item.Grupa,
                    Subgrupa = item.Subgrupa,
                    SpecializareId=item.SpecializareId, 
                    Specializare= await _context.Specializare.FindAsync(item.SpecializareId),
                    FacultateId = item.FacultateId,
                    Facultate = await _context.Facultate.FindAsync(item.FacultateId)
                });


            return v;
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentResponse>> GetStudent(string id)
        {
            var student = await _context.Student.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return new StudentResponse
            {
                Id = student.Id,
                Nume = student.Nume,
                Prenume = student.Prenume,
                Mail = student.Mail,
                An = student.An,
                Grupa = student.Grupa,
                Subgrupa = student.Subgrupa,
                SpecializareId = student.SpecializareId,
                Specializare = await _context.Specializare.FindAsync(student.SpecializareId),
                FacultateId = student.FacultateId,
                Facultate = await _context.Facultate.FindAsync(student.FacultateId)
            };
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(string id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Students
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Student.Add(student);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StudentExists(student.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(string id)
        {
            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Student.Remove(student);
            await _context.SaveChangesAsync();

            return student;
        }

        private bool StudentExists(string id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
