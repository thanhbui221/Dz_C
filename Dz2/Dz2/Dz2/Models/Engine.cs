using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Console;

namespace Dz2.Models
{
    public class Engine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EngineID { get; set; }
        public string model_name_engine { get; set; }
        public string serial_number_engine { get; set; }
        public string type_engine { get; set; }
        public virtual void CheckEngine()
        {
            string[] type = { "petrol", "diesel" };
            if (type.Contains(type_engine))
            {
                WriteLine("Type of engine need to be petrol or diesel");
            }
        }


    }
}