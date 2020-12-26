using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dz2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dz2.DAL
{
    public class DatabaseInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var engines = new List<Engine>
            {
            new Engine{EngineID = 1, model_name_engine="Porsche Flat-6", serial_number_engine="1E",type_engine="petrol"},
            new Engine{EngineID = 2,model_name_engine = "Ford Flathead V8", serial_number_engine = "2E",type_engine = "diesel"},
            new Engine{EngineID = 3, model_name_engine = "Duesenberg Straight-8", serial_number_engine = "3E",type_engine = "petrol"}
            };

            engines.ForEach(s => context.Engines.Add(s));
            context.SaveChanges();

            var cabins = new List<Cabin>
            {
            new Cabin{CabinID = 1, model_name_cabin="Cabin_1", serial_number_cabin="1C",type_cabin="standard"},
            new Cabin{CabinID = 2,model_name_cabin="Cabin_2", serial_number_cabin="2C",type_cabin="polar"},
            new Cabin{CabinID = 3,model_name_cabin="Cabin_3", serial_number_cabin="3C",type_cabin="tropical"}
            };

            cabins.ForEach(s => context.Cabins.Add(s));
            context.SaveChanges();

            var tractors = new List<Tractor>
            {
            new Tractor{TractorID = 1, CabinID =1, EngineID = 1,model_name_tractor="John Deere Tractors", serial_number_tractor="1T"},
            new Tractor{TractorID = 2, CabinID =2, EngineID = 2,model_name_tractor="Case IH Tractors", serial_number_tractor="2T"},
            new Tractor{TractorID = 3, CabinID =3, EngineID = 3,model_name_tractor="Massey Ferguson Tractors", serial_number_tractor="3T"}
            };

            tractors.ForEach(s => context.Tractors.Add(s));
            context.SaveChanges();
        }
        
    }
}