using System;
using System.Collections.Generic;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int? Age { get; set; }
        public int? AreaId { get; set; }

        public virtual Area Area { get; set; }
    }
}
