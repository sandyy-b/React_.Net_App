using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace React_.Net_App.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Designation { get; set; } = null!;
    }
}
