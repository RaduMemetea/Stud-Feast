using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Translates
{
    public class StudentResponse:Student
    {
        public virtual Facultate Facultate { get; set; }
        public virtual Specializare Specializare { get; set; }
    }
}
