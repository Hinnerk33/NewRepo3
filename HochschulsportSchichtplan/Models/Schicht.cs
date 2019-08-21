using System;
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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Tag { get; set; }

        [DataType(DataType.Time)]
        public DateTime Start{ get; set; }

        [DataType(DataType.Time)]
        public DateTime Ende { get; set; }

        public String Inhaber{ get; set; }
        public Double Stunden { get; set; }
    }
}

