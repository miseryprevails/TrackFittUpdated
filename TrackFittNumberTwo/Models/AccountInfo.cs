using System;
using System.Collections.Generic;

#nullable disable

namespace TrackFittNumberTwo.Models
{
    public partial class AccountInfo
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public  string Height { get; set; }
        public  string Weight { get; set; }
        public  string Age { get; set; }
    }
}
