using System;
using System.Collections.Generic;

#nullable disable

namespace TrackFittNumberTwo.Models
{
    public partial class MacronutrientMeasurement
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Calories { get; set; }
        public string Fat { get; set; }
        public string Carbs { get; set; }
        public string Protein { get; set; }
        public string Sugar { get; set; }
    }
}
