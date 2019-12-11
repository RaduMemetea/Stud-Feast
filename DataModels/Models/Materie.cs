using System.ComponentModel.DataAnnotations;

namespace DataModels.Models
{
    public class Materie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required] 
        public int Credite { get; set; }
    }
}