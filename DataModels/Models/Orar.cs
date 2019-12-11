using System;

namespace DataModels.Models
{
    public class Orar
    {
        public int Id { get; set; }
        public int FacultateId { get; set; }
        public int SpecializareId { get; set; }
        public int ProfesorId { get; set; }
        public string SalaId { get; set; }
        public int MaterieId { get; set; }
        public DateTimeOffset Ora { get; set; }
        public int An { get; set; }
        public int Grupa { get; set; }
        public int Subgrupa { get; set; }
        public bool? Curs { get; set; }
        public bool? Par_Impar { get; set; }
       
    }
}