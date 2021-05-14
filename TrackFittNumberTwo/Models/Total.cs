using System;
using System.Collections.Generic;

#nullable disable

namespace TrackFittNumberTwo.Models
{
    public partial class Total
    {
        public int Id { get; set; }
        public string TotalCalories { get; set; }
        public string TotalCarbs { get; set; }
        public string TotalFats { get; set; }
        public string TotalProtein { get; set; }
    }
}
