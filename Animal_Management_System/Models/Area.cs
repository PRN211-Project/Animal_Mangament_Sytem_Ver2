using System;
using System.Collections.Generic;

#nullable disable

namespace Animal_Management_System.Models
{
    public partial class Area
    {
        public Area()
        {
            Animals = new HashSet<Animal>();
            Employees = new HashSet<Employee>();
        }

        public int AreaId { get; set; }
        public string Name { get; set; }
        public double? Square { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
