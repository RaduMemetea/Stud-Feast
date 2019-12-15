using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Translates
{
    public class SpecializareResponse:Specializare
    {
        public virtual Facultate Facultate { get; set; }
    }
}
