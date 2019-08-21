﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace HochschulsportSchichtplan.Models
{
    public class Schicht
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tag { get; set; }

        [DataType(DataType.Time)]
        public DateTime Start{ get; set; }

        [DataType(DataType.Time)]
        public DateTime Ende { get; set; }

        public String Inhaber{ get; set; }
        public Double Stunden { get; set; }
    }
}

