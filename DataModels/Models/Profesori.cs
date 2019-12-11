using System.ComponentModel.DataAnnotations;

namespace DataModels.Models
{
    public class Profesori
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public string Prenume { get; set; }

        public string Detalii { get; set; }
    }
}
