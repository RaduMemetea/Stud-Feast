using DataModels.Models;

namespace DataModels.Translates
{
    public class OrarResponse : Orar
    {
        public virtual Facultate Facultate { get; set; }
        public virtual Specializare Specializare { get; set; }
        public virtual Profesori Profesor { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual Materie Materie { get; set; }


    }
}
