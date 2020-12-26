using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

namespace Dz2.Models
{
    public class Cabin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CabinID { get; set; }
        public string model_name_cabin { get; set; }
        public string serial_number_cabin { get; set; }
        public string type_cabin { get; set; }
        public virtual void CheckCabin()
        {
            string[] type = { "standard", "polar", "tropical" };
            if (type.Contains(type_cabin))
            {
                WriteLine("Type of cabin need to be standard, polar or tropical");
            }
        }


}
}