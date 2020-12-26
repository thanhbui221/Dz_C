using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ClassLibrary1
{
    public class Tractor
    {
        public Tractor() { }
        public Cabin cabin = new Cabin();
        public Engine engine = new Engine();
        public string model_name_tractor { get; set; }
        public string serial_number_tractor { get; set; }

    }

    public class Cabin
    {
  
        public string model_name_cabin { get; set; }
        public string serial_number_cabin { get; set; }
        public string type_cabin { get; set;}
        public void CheckCabin()
        {
            string[] type = { "standard", "polar", "tropical" };
            if (type.Contains(type_cabin))
            {
                WriteLine("Type of cabin need to be standard, polar or tropical");
            }
        }
       

    }

    public class Engine
    {
        public string model_name_engine { get; set; }
        public string serial_number_engine { get; set; }
        public string type_engine { get; set; }
        public void CheckEngine()
        {
            string[] type = {"petrol", "diesel"};
            if (type.Contains(type_engine))
            {
                WriteLine("Type of engine need to be petrol or diesel");
            }
        }
    }


}
