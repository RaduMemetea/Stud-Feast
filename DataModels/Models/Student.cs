using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataModels.Models
{
    public class Student
    {
        [Required]
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nume { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Prenume { get; set; }

        [Required]
        [StringLength(200)]
        public string Mail { get; set; }
        [ForeignKey("Facultate")]
        public int FacultateId { get; set; }
        [ForeignKey("Specializare")]
        public int SpecializareId { get; set; }
        public int An { get; set; }
        public int Grupa { get; set; }
        public int Subgrupa { get; set; }


    }
}
