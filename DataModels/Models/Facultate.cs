using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataModels.Models
{
    public class Facultate
    {
        [Required]
        public int Id { get; set; }
        [Required] 
        public string Nume { get; set; }
    }
}
