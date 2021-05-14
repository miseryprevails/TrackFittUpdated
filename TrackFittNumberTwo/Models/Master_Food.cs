using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackFittNumberTwo.Models
{
    public class Master_Food
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string  Food_Group { get; set; }

        public double Calories { get; set; }

        public double Fat_g { get; set; }

        public double Protein_g { get; set; }

        public double Carbohydrate_g { get; set; }
    }
}
