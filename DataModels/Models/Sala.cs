using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels.Models
{
    public class Sala
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Numar { get; set; }
        [Required]
        [ForeignKey("Facultate")]
        public int FacultateId { get; set; }
    }
}