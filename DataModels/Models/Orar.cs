using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels.Models
{
    public class Orar
    {
        public int Id { get; set; }
        [ForeignKey("Facultate")]
        public int FacultateId { get; set; }
        [ForeignKey("Specializare")] 
        public int SpecializareId { get; set; }
        [ForeignKey("Profesor")]
        public int ProfesorId { get; set; }
        [ForeignKey("Sala")]
        public int SalaId { get; set; }
        [ForeignKey("Materie")]
        public int MaterieId { get; set; }
        public virtual DateTimeOffset Ora { get; set; }
        public int An { get; set; }
        public int Grupa { get; set; }
        public int Subgrupa { get; set; }
        public bool? Curs { get; set; }
        public bool? Par_Impar { get; set; }
        
       
    }
}