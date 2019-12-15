using System;

namespace BackEnd
{/// <summary>
/// Acesta este o clasa asemanatoare cu Orar dat din cauza problemelor de deserializare la data a fost necesar un camp string
/// </summary>
    public class OrarT
    {
        public int Id { get; set; }
        public int FacultateId { get; set; }
        public int SpecializareId { get; set; }
        public int ProfesorId { get; set; }
        public int SalaId { get; set; }
        public int MaterieId { get; set; }
        public string Ora { get; set; }
        public int An { get; set; }
        public int Grupa { get; set; }
        public int Subgrupa { get; set; }
        public bool? Curs { get; set; }
        public bool? Par_Impar { get; set; }
        
       
    }
}