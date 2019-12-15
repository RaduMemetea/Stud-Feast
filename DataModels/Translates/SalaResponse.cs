using DataModels.Models;

namespace DataModels.Translates
{
    public class SalaResponse : Sala
    {

        public virtual Facultate Facultate { get; set; }

    }
}
