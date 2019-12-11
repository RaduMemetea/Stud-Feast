using System.ComponentModel.DataAnnotations;

namespace DataModels.Models
{
    public class Sala
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Numar { get; set; }
        [Required]
        public int FacultateId { get; set; }
    }
}