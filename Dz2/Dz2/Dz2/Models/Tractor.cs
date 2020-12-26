using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

namespace Dz2.Models
{
    public class Tractor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TractorID { get; set; }
        public int CabinID { get; set; }
        public int EngineID { get; set; }
        public virtual Cabin cabin { get; set; }
        public virtual Engine engine { get; set; }
        public string model_name_tractor { get; set; }
        public string serial_number_tractor { get; set; }


    }
}