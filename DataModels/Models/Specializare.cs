﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataModels.Models
{
    public class Specializare
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Facultate")]
        public int FacultateId { get; set; }

        [Required] 
        public string Nume { get; set; }

        [Required] 
        public int An { get; set; }


    }
}
